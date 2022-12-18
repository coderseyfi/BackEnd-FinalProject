using MediatR;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.ResumeModule.Diploma
{
    public class ResumeDiplomaRemoveCommand : IRequest<ResumeDiploma>
    {
        public int Id { get; set; }
        public class ResumeDiplomaRemoveCommandHandler : IRequestHandler<ResumeDiplomaRemoveCommand, ResumeDiploma>
        {
            private readonly CvWebDbContext db;

            public ResumeDiplomaRemoveCommandHandler(CvWebDbContext db)
            {
                this.db = db;
            }
            public async Task<ResumeDiploma> Handle(ResumeDiplomaRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeDiplomas.FirstOrDefaultAsync(re => re.Id == request.Id && re.DeletedDate == null);

                if (data == null)
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
