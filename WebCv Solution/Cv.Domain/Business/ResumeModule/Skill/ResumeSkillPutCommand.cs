using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Cv.Domain.AppCode.Infrastructure;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.ResumeModule.Skill
{
    public class ResumeSkillPutCommand : IRequest<JsonResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ResumeCategoryId { get; set; }
        public string Description { get; set; }

        public class ResumeSkillPutCommandHandler : IRequestHandler<ResumeSkillPutCommand, JsonResponse>
        {
            private readonly CvWebDbContext db;
            private readonly IHostEnvironment env;

            public ResumeSkillPutCommandHandler(CvWebDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(ResumeSkillPutCommand request, CancellationToken cancellationToken)
            {
                var entity = db.ResumeSkills.FirstOrDefault(bg => bg.Id == request.Id && bg.DeletedDate == null);


                if (entity == null)
                {
                    return null;
                }


                entity.Name = request.Name;
                entity.ResumeCategoryId = request.ResumeCategoryId;
                entity.Level = request.Level;
                entity.Description = request.Description;

                
                await db.SaveChangesAsync(cancellationToken);
                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                };
            }
        }
    }
}
