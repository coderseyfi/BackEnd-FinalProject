using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Cv.Domain.AppCode.Extensions;
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

namespace Cv.Domain.Business.ResumeModule.Experience
{
    public class ResumeExperiencePostCommand : IRequest<JsonResponse>
    {
        public string Title { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public string CompanyName { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class ResumeExperiencePostCommandHandler : IRequestHandler<ResumeExperiencePostCommand, JsonResponse>
        {
            private readonly CvWebDbContext db;
            private readonly IHostEnvironment env;

            public ResumeExperiencePostCommandHandler(CvWebDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(ResumeExperiencePostCommand request, CancellationToken cancellationToken)
            {
                var entity = new ResumeExperience();

                entity.Title = request.Title;
                entity.StartYear = request.StartYear;
                entity.EndYear = request.EndYear;
                entity.CompanyName = request.CompanyName;
                entity.Location = request.Location;
                entity.Details = request.Details;


                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName);//.jpg

                request.ImagePath = $"experience-{Guid.NewGuid().ToString().ToLower()}{extension}";
                string fullPath = env.GetImagePhysicalPath(request.ImagePath);

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                entity.ImagePath = request.ImagePath;

            end:
                await db.AddAsync(entity, cancellationToken);
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
