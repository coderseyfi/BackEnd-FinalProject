using Cv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.Models.Entities
{
    public class About : BaseEntity
    {
        [Required(ErrorMessage = "bos buraxila bilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "bos buraxila bilmez")]
        public int Age { get; set; }

        [Required(ErrorMessage = "bos buraxila bilmez")]
        public string Location { get; set; }

        [Required(ErrorMessage = "bos buraxila bilmez")]
        public int Experince { get; set; }

        public string Degree { get; set; }
        public string CareerLevel { get; set; }

        [Required(ErrorMessage = "bos buraxila bilmez")]
        public string Phone { get; set; }
        public string Fax { get; set; }

        [Required(ErrorMessage = "bos buraxila bilmez")]
        public string Email { get; set; }
        public string Website { get; set; }

        [Required(ErrorMessage = "bos buraxila bilmez")]
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
