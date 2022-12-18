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

namespace Cv.Domain.Business.ResumeModule.Skill
{
    public class ResumeSkillGetAllQuery : IRequest<List<ResumeSkill>>
    {
        public class ResumeSkillGetAllQueryHandler : IRequestHandler<ResumeSkillGetAllQuery, List<ResumeSkill>>
        {
            private readonly CvWebDbContext db;

            public ResumeSkillGetAllQueryHandler(CvWebDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ResumeSkill>> Handle(ResumeSkillGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeSkills.Where(re => re.DeletedDate == null).Include(re=>re.ResumeCategory).ToListAsync(cancellationToken);
                return data;
            }
        }
    }
}
