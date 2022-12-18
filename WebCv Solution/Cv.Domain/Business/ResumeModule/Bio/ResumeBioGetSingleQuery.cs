using MediatR;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.ResumeModule.Bio
{
    public class ResumeBioGetSingleQuery : IRequest<ResumeBio>
    {
        public int Id { get; set; }
        public class BlogPostGetSingleQueryHandler : IRequestHandler<ResumeBioGetSingleQuery, ResumeBio>
        {
            private readonly CvWebDbContext db;

            public BlogPostGetSingleQueryHandler(CvWebDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeBio> Handle(ResumeBioGetSingleQuery request, CancellationToken cancellationToken)
            {
                var query = await db.ResumeBios.FirstOrDefaultAsync(m => m.Id == request.Id, cancellationToken);
                return query;
            }
        }
    }
}
