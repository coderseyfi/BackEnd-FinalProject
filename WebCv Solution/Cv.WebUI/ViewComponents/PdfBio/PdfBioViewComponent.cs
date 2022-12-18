using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Business.ResumeModule.Bio;
using Cv.Domain.Models.DataContexts;
using System.Threading.Tasks;

namespace Cv.WebUI.AppCode.ViewComponents.PdfBio
{
    public class PdfBioViewComponent : ViewComponent
    {
        private readonly CvWebDbContext db;

        public PdfBioViewComponent(CvWebDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.ResumeBios.FirstOrDefaultAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
