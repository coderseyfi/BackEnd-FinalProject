using MediatR;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.ResumeModule.Experience
{
    public class ResumeExperienceRemoveCommand : IRequest<ResumeExperience>
    {
        public int Id { get; set; }
        public class ResumeExperienceRemoveCommandHandler : IRequestHandler<ResumeExperienceRemoveCommand, ResumeExperience>
        {
            private readonly CvWebDbContext db;

            public ResumeExperienceRemoveCommandHandler(CvWebDbContext db)
            {
                this.db = db;
            }
            public async Task<ResumeExperience> Handle(ResumeExperienceRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeExperiences.FirstOrDefaultAsync(re => re.Id == request.Id && re.DeletedDate ==  null);
                
                if(data == null)
                {
                    return null;
                }
                data.DeletedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
