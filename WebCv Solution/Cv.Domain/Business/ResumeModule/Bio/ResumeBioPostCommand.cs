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

namespace Cv.Domain.Business.ResumeModule.Bio
{
    public class ResumeBioPostCommand : IRequest<JsonResponse>
    {
        public string Text { get; set; }

        public class ResumeBioPostCommandHandler : IRequestHandler<ResumeBioPostCommand, JsonResponse>
        {
            private readonly CvWebDbContext db;
            public ResumeBioPostCommandHandler(CvWebDbContext db)
            {
                this.db = db;
            }
            public async Task<JsonResponse> Handle(ResumeBioPostCommand request, CancellationToken cancellationToken)
            {
                var entity = new ResumeBio();

                entity.Text = request.Text;

                await db.ResumeBios.AddAsync(entity, cancellationToken);
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
