using Cv.Domain.AppCode.Extensions;
using Cv.Domain.Business.BlogPostModule;
using Cv.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cv.WebUI.Controllers
{

    public class BlogController : Controller
    {
        private readonly IMediator mediator;
        private readonly CvWebDbContext db;

        public BlogController(IMediator mediator,CvWebDbContext db)
        {
            this.mediator = mediator;
            this.db = db;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_PostsBody", response);
            }
            return View(response);
        }



        [AllowAnonymous]
        [HttpGet]
        [Route("/blog/{slug}")]
        public async Task<IActionResult> Details(BlogPostGetSingleQuery query)
        {

            var blogPost = await mediator.Send(query);

            if (blogPost == null)
            {
                return NotFound();
            }


            return View(blogPost);
        }

        [HttpPost]
        public async Task<IActionResult> PostComment(BlogPostCommentCommand command)
        {

            try
            {
                var response = await mediator.Send(command);
                return PartialView("_Comments", response);
            }
            catch (System.Exception ex)
            {
                return Json(new
                {
                    error = true,
                    message = ex.Message
                });
            }

            //return Json(response);

        }


    }
}
