using Cv.Domain.AppCode.Infrastructure;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using MediatR;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;


namespace Cv.Domain.Business.BlogPostModule
{
    public class AboutCreateCommand : IRequest<JsonResponse>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public int Experince { get; set; }
        public string Degree { get; set; }
        public string CareerLevel { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public class AboutCreateCommandHandler : IRequestHandler<AboutCreateCommand, JsonResponse>
        {
            private readonly CvWebDbContext db;
            private readonly IHostEnvironment env;

            public AboutCreateCommandHandler(CvWebDbContext db, IHostEnvironment env)
            {
                this.db = db;
            }

            
            public async Task<JsonResponse> Handle(AboutCreateCommand request, CancellationToken cancellationToken)
            {
                var entity = new About();

                entity.Name = request.Name;
                entity.Age = request.Age;
                entity.Location = request.Location;
                entity.Experince = request.Experince;
                entity.Degree = request.Degree;
                entity.CareerLevel = request.CareerLevel;
                entity.Phone = request.Phone;
                entity.Fax = request.Fax;
                entity.Email = request.Email;
                entity.Website = request.Website;
                entity.ShortDescription = request.ShortDescription;
                entity.LongDescription = request.LongDescription;

                await db.Abouts.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                };
            }
        }
    }
}
