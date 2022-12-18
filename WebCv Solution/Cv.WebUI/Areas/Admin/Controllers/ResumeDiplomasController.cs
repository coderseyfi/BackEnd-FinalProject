using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Business.ResumeModule.Diploma;
using Cv.Domain.Business.ResumeModule.Experience;
using Cv.Domain.Models.DataContexts;
using Cv.Domain.Models.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CvWeb.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "sa")]
    [Area("Admin")]
    public class ResumeDiplomsController : Controller
    {
        private readonly CvWebDbContext db;
        private readonly IMediator mediator;

        public ResumeDiplomsController(CvWebDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        // GET: Admin/ResumeDiploms
        public async Task<IActionResult> Index(ResumeDiplomaGetAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }

        // GET: Admin/ResumeDiploms/Details/5
        public async Task<IActionResult> Details(ResumeDiplomaGetSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }
            return View(response);
        }

        // GET: Admin/ResumeDiploms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ResumeDiploms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ResumeDiplomaPostCommand command)
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

        // GET: Admin/ResumeDiploms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeDiploma = await db.ResumeDiplomas.FindAsync(id);
            if (resumeDiploma == null)
            {
                return NotFound();
            }
            var editCommand = new ResumeDiplomaPutCommand();
            editCommand.Id = resumeDiploma.Id;
            editCommand.Degree = resumeDiploma.Degree;
            editCommand.StartYear = resumeDiploma.StartYear;
            editCommand.EndYear = resumeDiploma.EndYear;
            editCommand.UniversityName = resumeDiploma.UniversityName;
            editCommand.YearObtention = resumeDiploma.YearObtention;
            editCommand.Details = resumeDiploma.Details;
            editCommand.ImagePath = resumeDiploma.ImagePath;
            return View(resumeDiploma);
        }

        // POST: Admin/ResumeDiploms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ResumeDiplomaPutCommand command)
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

        // POST: Admin/ResumeDiploms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, ResumeDiplomaRemoveCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

        private bool ResumeDiplomaExists(int id)
        {
            return db.ResumeDiplomas.Any(e => e.Id == id);
        }
    }
}
