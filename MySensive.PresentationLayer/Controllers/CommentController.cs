using Microsoft.AspNetCore.Mvc;
using MySensive.BusinessLayer.Abstract;
using MySensive.EntityLayer.Entities;

namespace MySensive.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IArticleService _articleService;

        public CommentController(ICommentService commentService, IArticleService articleService)
        {
            _commentService = commentService;
            _articleService = articleService;
        }

        public IActionResult CommentList()
        {
            var commentList = _commentService.TGetAll();
            return View(commentList);
        }

        public IActionResult DeleteComment(int id)
        {
            _commentService.TDelete(id);
            return RedirectToAction("CommentList");
        }


        [HttpGet]
        public async Task<IActionResult> EditComment(int id)
        {
            var comment = _commentService.TGetById(id);
            return View(comment);
        }

        [HttpPost]
        public async Task<IActionResult> EditComment(Comment comment)
        {
            var Comment = _commentService.TGetById(comment.CommentId);
            if (Comment == null)
            {
                return NotFound();
            }

            Comment.Detail = comment.Detail;
            Comment.CreatedDate = DateTime.Now;

            _commentService.TUpdate(Comment);

            return RedirectToAction("CommentList");
        }

    }
}
