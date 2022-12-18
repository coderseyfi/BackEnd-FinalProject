using Cv.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.Models.Entities
{
  public  class Project : BaseEntity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Link { get; set; }

        public int ProjectCategoryId { get; set; }

        public virtual ProjectCategory ProjectCategory { get; set; }
    }
}
