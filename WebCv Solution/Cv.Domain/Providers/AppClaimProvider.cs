using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Models.DataContexts;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Models.AppCode.Providers
{
    public class AppClaimProvider : IClaimsTransformation
    {
        private readonly CvWebDbContext db;

        public AppClaimProvider(CvWebDbContext db)
        {
            this.db = db;
        }
        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (principal.Identity.IsAuthenticated && principal.Identity is ClaimsIdentity currentIdentity)
            {
                var userId = Convert.ToInt32(currentIdentity.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier))?.Value);

                var user = await db.Users.FirstOrDefaultAsync(u => u.Id == userId);

                if (user != null)
                {
                    currentIdentity.AddClaim(new Claim("name", user.Name));
                    currentIdentity.AddClaim(new Claim("surname", user.Surname));
                }
            }

            return principal;
        }
    }
}