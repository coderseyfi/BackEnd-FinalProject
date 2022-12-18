using Cv.Domain.Models.Entities;
using System.Collections.Generic;

namespace Cv.Domain.Models.ViewModels
{
    public class PortfolioViewModel
    {
        public ICollection<ProjectCategory> ProjectCategories { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
