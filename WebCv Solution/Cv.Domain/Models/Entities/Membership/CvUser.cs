using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Cv.Domain.Models.Entities.Membership
{
    public class CvUser : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        [Required]

        public string Surname { get; set; }
    }
}
