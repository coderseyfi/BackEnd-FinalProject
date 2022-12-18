using Cv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.Models.Entities
{
  public  class ContactPost: BaseEntity
    {
        [Required(ErrorMessage = "{0} bos buraxila bilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "bos buraxila bilmez")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "bos buraxila bilmez")]

        public string Subject { get; set; }
        [Required(ErrorMessage = "bos buraxila bilmez")]

        public string Content { get; set; }
        public string Answer { get; set; }
        public string EmailSubject { get; set; }
        public DateTime? AnswerDate { get; set; }
    }
}
