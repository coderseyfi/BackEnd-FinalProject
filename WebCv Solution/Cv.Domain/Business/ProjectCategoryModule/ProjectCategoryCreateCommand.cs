using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.ProjectCategoryModule
{
     public class ProjectCategoryCreateCommand : IRequest<ProjectCategory> 
    {
        public string Name { get; set; }
        public class ProjectCategoryCreateCommandHandler : IRequestHandler<ProjectCategoryCreateCommand, ProjectCategory>
        {
            private readonly CvWebDbContext db;

            public ProjectCategoryCreateCommandHandler(CvWebDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryCreateCommand request, CancellationToken cancellationToken)
            {
                var model = new ProjectCategory();

                model.Name = request.Name;

                await db.ProjectCategories.AddAsync(model, cancellationToken);

                await db.SaveChangesAsync(cancellationToken);

                return model;
            }


        }
    }
}
