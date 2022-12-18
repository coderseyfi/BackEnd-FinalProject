using MediatR;
using Cv.Domain.AppCode.Infrastructure;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.ResumeModule.Skill
{
    public class ResumeCategoryPostCommand : IRequest<JsonResponse>
    {
        public string Name { get; set; }
        public class ResumeCategoryPostCommandHandler : IRequestHandler<ResumeCategoryPostCommand, JsonResponse>
        {
            private readonly CvWebDbContext db;

            public ResumeCategoryPostCommandHandler(CvWebDbContext db)
            {
                this.db = db;
            }
            public async Task<JsonResponse> Handle(ResumeCategoryPostCommand request, CancellationToken cancellationToken)
            {
                var data = new ResumeCategory();
                data.Name = request.Name;
                await db.ResumeCategories.AddAsync(data, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);
                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                }; ;
            }
        }
    }
}
