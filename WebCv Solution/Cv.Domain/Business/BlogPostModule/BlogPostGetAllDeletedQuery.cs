using MediatR;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.BlogPostModule
{
    public class BlogPostGetAllDeletedQuery : IRequest<List<BlogPost>>
    {
        public class BlogPostGetAllDeletedHandler : IRequestHandler<BlogPostGetAllDeletedQuery, List<BlogPost>>
        {
            private readonly CvWebDbContext db;

            public BlogPostGetAllDeletedHandler(CvWebDbContext db)
            {
                this.db = db;
            }


            public async Task<List<BlogPost>> Handle(BlogPostGetAllDeletedQuery request, CancellationToken cancellationToken)
            {
                var query = await db.BlogPosts.Where(bp => bp.DeletedDate != null) //&& bp.PublishedDate != null)
                                             .ToListAsync(cancellationToken);
                return query;
            }
        }
    }
}
