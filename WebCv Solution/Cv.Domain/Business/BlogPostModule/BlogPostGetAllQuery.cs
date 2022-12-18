using Cv.Domain.AppCode.Infracture;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cv.Domain.Business.BlogPostModule
{
    public class BlogPostGetAllQuery : PaginateModel, IRequest<PagedViewModel<BlogPost>>
    {
        public class BlogPostGetAllHandler : IRequestHandler<BlogPostGetAllQuery, PagedViewModel<BlogPost>>
        {
            private readonly CvWebDbContext db;

            public BlogPostGetAllHandler(CvWebDbContext db)
            {
                this.db = db;
            }


            public async Task<PagedViewModel<BlogPost>> Handle(BlogPostGetAllQuery request, CancellationToken cancellationToken)
            {
                if (request.PageSize <= 6)
                {
                    request.PageSize = 6;
                }


                int skipSize = (request.PageIndex - 1) * request.PageSize;
                var query = db.BlogPosts.Where(bp => bp.DeletedDate == null && bp.PublishedDate != null)
                                             .OrderByDescending(bp => bp.PublishedDate)
                                             .AsQueryable();


                var pagedModel = new PagedViewModel<BlogPost>(query, request);

                return pagedModel;
            }
        }
    }
}