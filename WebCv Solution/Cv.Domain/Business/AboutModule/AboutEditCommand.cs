using MediatR;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using System.Threading;
using System.Threading.Tasks;
using Cv.Domain.AppCode.Infrastructure;


namespace Cv.Domain.Business.AboutModule
{
public class AboutEditCommand : IRequest<JsonResponse>
{
    public int Id { get; set; }
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



    public class AboutEditCommandHandler : IRequestHandler<AboutEditCommand, JsonResponse>
    {
        private readonly CvWebDbContext db;

        public AboutEditCommandHandler(CvWebDbContext db)
        {
            this.db = db;
        }

        public async Task<JsonResponse> Handle(AboutEditCommand request, CancellationToken cancellationToken)
        {
            var data = await db.Abouts
                .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

            if (data == null)
            {
                return null;
            }

            data.Name = request.Name;
            data.Age = request.Age;
            data.Location = request.Location;
            data.Experince = request.Experince;
            data.Degree = request.Degree;
            data.CareerLevel = request.CareerLevel;
            data.Phone = request.Phone;
            data.Fax = request.Fax;
            data.Email = request.Email;
            data.Website = request.Website;
            data.ShortDescription = request.ShortDescription;
            data.LongDescription = request.LongDescription;


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