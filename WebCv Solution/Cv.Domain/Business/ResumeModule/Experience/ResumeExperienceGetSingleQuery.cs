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

namespace Cv.Domain.Business.ResumeModule.Experience
{
    
    public class ResumeExperienceGetSingleQuery : IRequest<ResumeExperience>
    {
        public int Id { get; set; }
        public class ResumeExperienceGetSingleQueryHandler : IRequestHandler<ResumeExperienceGetSingleQuery, ResumeExperience>
        {
            private readonly CvWebDbContext db;

            public ResumeExperienceGetSingleQueryHandler(CvWebDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeExperience> Handle(ResumeExperienceGetSingleQuery request, CancellationToken cancellationToken)
            {
                var query = await db.ResumeExperiences.FirstOrDefaultAsync(re => re.Id == request.Id, cancellationToken);
                return query;
            }
        }
    }
}
