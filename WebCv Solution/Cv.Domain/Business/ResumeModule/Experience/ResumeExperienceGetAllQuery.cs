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
    public class ResumeExperienceGetAllQuery : IRequest<List<ResumeExperience>>
    {
        public class ResumeExperienceGetAllQueryHandler : IRequestHandler<ResumeExperienceGetAllQuery, List<ResumeExperience>>
        {
            private readonly CvWebDbContext db;

            public ResumeExperienceGetAllQueryHandler(CvWebDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ResumeExperience>> Handle(ResumeExperienceGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeExperiences.Where(re => re.DeletedDate == null).ToListAsync(cancellationToken);
                return data;
            }
        }
    }
}
