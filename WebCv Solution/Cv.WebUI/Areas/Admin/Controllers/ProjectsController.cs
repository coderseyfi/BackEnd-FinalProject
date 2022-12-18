using Cv.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cv.Domain.Business.ProjectsModule;
using System.Linq;
using System.Threading.Tasks;

namespace Cv.WebUI.Areas.Admin.Controllers
{

        [Area("Admin")]
        public class ProjectsController : Controller
        {
            private readonly CvWebDbContext db;
            private readonly IMediator mediator;

            public ProjectsController(CvWebDbContext db, IMediator mediator)
            {
                this.db = db;
                this.mediator = mediator;
            }

            // GET: Admin/Projects
            public async Task<IActionResult> Index(ProjectGetAllQuery query)
            {
                var response = await mediator.Send(query);

                if (response == null)
                {
                    return NotFound();
                }


                return View(response);
            }

            // GET: Admin/Projects/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var project = await db.Projects
                    .Include(p => p.ProjectCategory)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (project == null)
                {
                    return NotFound();
                }

                return View(project);
            }

            // GET: Admin/Projects/Create
            public IActionResult Create()
            {
                ViewBag.ProjectCategoryId = new SelectList(db.ProjectCategories.Where(pc => pc.DeletedDate == null), "Id", "Name");
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(ProjectsCreateCommand command)
            {
                if (command.Image == null)
                {
                    ModelState.AddModelError("ImagePath", "Şəkil göndərilməlidir");
                }

                if (ModelState.IsValid)
                {
                    var response = await mediator.Send(command);

                    if (response.Error == false)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                }

                ViewBag.ProjectCategoryId = new SelectList(db.ProjectCategories, "Id", "Name", command.ProjectCategoryId);

                return View(command);
            }

            // GET: Admin/Projects/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var project = await db.Projects.FindAsync(id);

                if (project == null)
                {
                    return NotFound();
                }

                ViewBag.ProjectCategoryId = new SelectList(db.ProjectCategories.Where(pc => pc.DeletedDate == null), "Id", "Name", project.ProjectCategoryId);

                var editCommand = new ProjectEditCommand();

                editCommand.Id = project.Id;
                editCommand.Name = project.Name;
                editCommand.ImagePath = project.ImagePath;
                editCommand.ProjectCategoryId = project.ProjectCategoryId;


                return View(editCommand);

            }


            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int? id, ProjectEditCommand command)
            {
                if (id != command.Id)
                {
                    return NotFound();
                }

                var response = await mediator.Send(command);

                if (response == null)
                {
                    return NotFound();
                }

                if (response.Error == false)
                {
                    return RedirectToAction(nameof(Index));
                }

                ViewBag.ProjectCategoryId = new SelectList(db.ProjectCategories.Where(pc => pc.DeletedDate == null), "Id", "Name", command.ProjectCategoryId);

                return View(command);

            }

            // GET: Admin/Projects/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var project = await db.Projects
                    .Include(p => p.ProjectCategory)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (project == null)
                {
                    return NotFound();
                }

                return View(project);
            }

            // POST: Admin/Projects/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var project = await db.Projects.FindAsync(id);
                db.Projects.Remove(project);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool ProjectExists(int id)
            {
                return db.Projects.Any(e => e.Id == id);
            }
        }
    }

