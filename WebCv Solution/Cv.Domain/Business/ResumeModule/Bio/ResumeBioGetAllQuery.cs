using MediatR;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.ResumeModule.Bio
{
    public class ResumeBioGetAllQuery : IRequest<ResumeBio>
    {
        public class ResumeBioGetAllQueryHandler : IRequestHandler<ResumeBioGetAllQuery, ResumeBio>
        {
            private readonly CvWebDbContext db;

            public ResumeBioGetAllQueryHandler(CvWebDbContext db)
            {
                this.db = db;
            }
            public async Task<ResumeBio> Handle(ResumeBioGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeBios.FirstOrDefaultAsync(cancellationToken);
                return data;
            }
        }
    }
}
