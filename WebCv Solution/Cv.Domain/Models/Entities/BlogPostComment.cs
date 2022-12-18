using Cv.Domain.AppCode.Infrastructure;
using Cv.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.Models.Entities
{
 public   class BlogPostComment : BaseEntity
    {
        public string Comment { get; set; }
        public int BlogPostId { get; set; }
        public virtual  BlogPost BlogPost { get; set; }
        public int? ParentId { get; set; }
        public virtual BlogPostComment Parent { get; set; }
        public int? CreatedByUserId { get; set; }
        public virtual CvUser CreatedByUser { get; set; }

        public virtual ICollection<BlogPostComment> Children { get; set; }

    }
}
