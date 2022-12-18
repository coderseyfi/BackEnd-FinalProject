using Cv.Domain.AppCode.Infracture;
using Cv.Domain.AppCode.Infrastructure;
using Cv.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cv.Domain.Models.Entities
{
    public class BlogPost : BaseEntity,IPageable
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public string ImagePath { get; set; }
        public string Slug { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? AuthorId { get; set; }
        public int? CreatedByUserId { get; set; }
        public virtual CvUser CreatedByUser { get; set; }
        public virtual ICollection<BlogPostComment> Comments { get; set; }
    }
}
