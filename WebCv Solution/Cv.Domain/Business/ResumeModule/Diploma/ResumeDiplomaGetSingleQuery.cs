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

namespace Cv.Domain.Business.ResumeModule.Diploma
{

    public class ResumeDiplomaGetSingleQuery : IRequest<ResumeDiploma>
    {
        public int Id { get; set; }
        public class ResumeDiplomaGetSingleQueryHandler : IRequestHandler<ResumeDiplomaGetSingleQuery, ResumeDiploma>
        {
            private readonly CvWebDbContext db;

            public ResumeDiplomaGetSingleQueryHandler(CvWebDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeDiploma> Handle(ResumeDiplomaGetSingleQuery request, CancellationToken cancellationToken)
            {
                var query = await db.ResumeDiplomas.FirstOrDefaultAsync(re => re.Id == request.Id, cancellationToken);
                return query;
            }
        }
    }
}
