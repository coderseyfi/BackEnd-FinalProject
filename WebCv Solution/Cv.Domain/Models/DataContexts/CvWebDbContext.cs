using Cv.Domain.Models.Entities;
using Cv.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.Models.DataContexts
{
   public class CvWebDbContext : IdentityDbContext<CvUser, CvRole, int, CvUserClaim,
        CvUserRole,
        CvUserLogin, CvRoleClaim, CvUserToken>
    {
        public CvWebDbContext(DbContextOptions options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CvUser>(e =>
            {
                e.ToTable("Users", "Membership");
            });
            builder.Entity<CvRole>(e =>
            {
                e.ToTable("Roles", "Membership");
            });
            builder.Entity<CvUserRole>(e =>
            {
                e.ToTable("UserRoles", "Membership");

            });
            builder.Entity<CvUserClaim>(e =>
            {
                e.ToTable("UserClaims", "Membership");
            });
            builder.Entity<CvRoleClaim>(e =>
            {
                e.ToTable("RoleClaims", "Membership");

            });
            builder.Entity<CvUserLogin>(e =>
            {
                e.ToTable("UserLogins", "Membership");
            });
            builder.Entity<CvUserToken>(e =>
            {
                e.ToTable("UserTokens", "Membership");
            });
        }

        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostComment> BlogPostComments { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ResumeBio> ResumeBios { get; set; }
        public DbSet<ResumeCategory> ResumeCategories { get; set; }
        public DbSet<ResumeSkill> ResumeSkills { get; set; }
        public DbSet<ResumeExperience> ResumeExperiences { get; set; }
        public DbSet<ResumeDiploma> ResumeDiplomas { get; set; }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }

    }
}
