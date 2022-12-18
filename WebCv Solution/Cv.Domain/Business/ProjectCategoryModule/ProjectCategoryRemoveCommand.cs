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

namespace BigOn.Domain.Business.ProjectCategoryModule
{ 
    public class ProjectCategoryRemoveCommand : IRequest<ProjectCategory>
    {
        public int Id { get; set; }

        public class ProjectCategoryRemoveCommandHandler : IRequestHandler<ProjectCategoryRemoveCommand, ProjectCategory>
        {
            private readonly CvWebDbContext db;

            public ProjectCategoryRemoveCommandHandler(CvWebDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ProjectCategories
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);

                return data;
            }


        }
    }
    
}
