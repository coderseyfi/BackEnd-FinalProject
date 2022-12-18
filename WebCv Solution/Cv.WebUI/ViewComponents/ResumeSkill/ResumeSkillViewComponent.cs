using Cv.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume.WebUI.ViewComponents.ResumeSkill
{
    public class ResumeSkillViewComponent : ViewComponent
    {
        private readonly CvWebDbContext db;

        public ResumeSkillViewComponent(CvWebDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.ResumeSkills.Where(re => re.DeletedDate == null && re.SelectedDate != null).Include(re => re.ResumeCategory).ToListAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
