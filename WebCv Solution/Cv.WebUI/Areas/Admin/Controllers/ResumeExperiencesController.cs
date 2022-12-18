using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Business.ResumeModule.Experience;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CvWeb.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "sa")]
    [Area("Admin")]
    public class ResumeExperiencesController : Controller
    {
        private readonly CvWebDbContext db;
        private readonly IMediator mediator;

        public ResumeExperiencesController(CvWebDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        // GET: Admin/ResumeExperiences
        public async Task<IActionResult> Index(ResumeExperienceGetAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }

        // GET: Admin/ResumeExperiences/Details/5
        public async Task<IActionResult> Details(ResumeExperienceGetSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }
            return View(response);
        }

        // GET: Admin/ResumeExperiences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ResumeExperiences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ResumeExperiencePostCommand command)
        {
            if (command.Image == null)
            {
                ModelState.AddModelError("ImagePath", "Shekil Gonderilmelidir");
            }

            if (ModelState.IsValid)
            {
                var response = await mediator.Send(command);
                if (response.Error == false)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(command);
        }

        // GET: Admin/ResumeExperiences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeExperience = await db.ResumeExperiences.FindAsync(id);
            if (resumeExperience == null)
            {
                return NotFound();
            }
            var editCommand = new ResumeExperiencePutCommand();
            editCommand.Id = resumeExperience.Id;
            editCommand.Title = resumeExperience.Title;
            editCommand.StartYear = resumeExperience.StartYear;
            editCommand.EndYear = resumeExperience.EndYear;
            editCommand.CompanyName = resumeExperience.CompanyName;
            editCommand.Location = resumeExperience.Location;
            editCommand.Details = resumeExperience.Details;
            editCommand.ImagePath = resumeExperience.ImagePath;
            return View(resumeExperience);
        }

        // POST: Admin/ResumeExperiences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ResumeExperiencePutCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);
            if (response != null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(command);
        }


        // POST: Admin/ResumeExperiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, ResumeExperienceRemoveCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

        private bool ResumeExperienceExists(int id)
        {
            return db.ResumeExperiences.Any(e => e.Id == id);
        }
    }
}
