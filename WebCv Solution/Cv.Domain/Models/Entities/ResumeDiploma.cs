using Cv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.Models.Entities
{
    public class ResumeDiploma : BaseEntity
    {
        [Required]
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string UniversityName { get; set; }
        public int YearObtention { get; set; }
        public string Details { get; set; }
        public string ImagePath { get; set; }

    }
}
