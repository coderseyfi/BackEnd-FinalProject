using MediatR;
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
    public class ResumeSkillViewCommand : IRequest<ResumeSkill>
    {
        public int Id { get; set; }
        public class ResumeSkillViewCommandHandler : IRequestHandler<ResumeSkillViewCommand, ResumeSkill>
        {
            private readonly CvWebDbContext db;

            public ResumeSkillViewCommandHandler(CvWebDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeSkill> Handle(ResumeSkillViewCommand request, CancellationToken cancellationToken)
            {
                string tag = "tag";
                var data = db.ResumeSkills.FirstOrDefault(m => m.Id == request.Id);

                if (data == null)
                {
                    return null;
                }
                if(data.View != null)
                {
                    data.View = null;
                }
                else if(data.View == null)
                {
                data.View = tag ;
                }
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
