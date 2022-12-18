using Cv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.Models.Entities
{
   public class ResumeSkill : BaseEntity
    {

        [Required]
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public DateTime? SelectedDate { get; set; }
        public string View { get; set; }
        [Required]
        public int ResumeCategoryId { get; set; }
        public virtual ResumeCategory ResumeCategory { get; set; }

    }
}
