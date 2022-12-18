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
    public class ResumeSkillSelectedDateCommand : IRequest<ResumeSkill>
    {
        public int Id { get; set; }
        public class ResumeSkillSelectedDateCommandHandler : IRequestHandler<ResumeSkillSelectedDateCommand, ResumeSkill>
        {
            private readonly CvWebDbContext db;

            public ResumeSkillSelectedDateCommandHandler(CvWebDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeSkill> Handle(ResumeSkillSelectedDateCommand request, CancellationToken cancellationToken)
            {
                var data = db.ResumeSkills.FirstOrDefault(m => m.Id == request.Id);

                if (data == null)
                {
                    return null;
                }
                if(data.SelectedDate != null)
                {
                    data.SelectedDate = null;
                }
                else if(data.SelectedDate == null)
                {
                data.SelectedDate = DateTime.UtcNow.AddHours(4);
                }
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
