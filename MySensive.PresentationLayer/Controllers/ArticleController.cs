using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySensive.BusinessLayer.Abstract;
using MySensive.EntityLayer.Entities;
using MySensive.PresentationLayer.Models;

namespace MySensive.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public IActionResult ArticleList()
        {
            var articleList = _articleService.TGetAll();
            return View(articleList);
        }
        [HttpGet]
        public IActionResult CreateArticle()
        {
            var categoryList = _categoryService.TGetAll();

            var model = new ArticleCategoryViewModel
            {
                Article = new Article(),
                Category = new Category(),
                CategoryList = categoryList.Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList()
            };

            model.CategoryList.Insert(0, new SelectListItem { Text = "Kategori seçiniz", Value = "" });
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticle(ArticleCategoryViewModel model)
        {
            if (model.Article == null)
            {
                ModelState.AddModelError("", "Article is null");
                return View(model);
            }

            model.Article.CreatedDate = DateTime.Now;
            _articleService.TInsert(model.Article);

            var categoryList = _categoryService.TGetAll();
            model.CategoryList = categoryList.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }).ToList();
            model.CategoryList.Insert(0, new SelectListItem { Text = "Kategori seçiniz", Value = "" });


            return RedirectToAction("ArticleList");
        }

        public IActionResult DeleteArticle(int id)
        {
            _articleService.TDelete(id);
            return RedirectToAction("MyArticleList");
        }

        [HttpGet]
        public IActionResult EditArticle(int id)
        {
            var article = _articleService.TGetByIdWithCategory(id); // Mevcut makaleyi getir

            if (article == null)
            {
                return NotFound();
            }

            var categoryList = _categoryService.TGetAll();

            var model = new ArticleCategoryViewModel
            {
                Article = article,
                CategoryList = categoryList.Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString(),
                    Selected = x.CategoryId == article.CategoryId // Seçili kategori ayarı
                }).ToList()
            };

            model.CategoryList.Insert(0, new SelectListItem { Text = "Kategori seçiniz", Value = "" });

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditArticle(ArticleCategoryViewModel model)
        {
            if (model.Article == null)
            {
                ModelState.AddModelError("", "Article is null");
                return View(model);
            }

            // Mevcut makaleyi kontrol et
            var existingArticle = _articleService.TGetById(model.Article.ArticleId);
            if (existingArticle == null)
            {
                return NotFound();
            }

            existingArticle.Title = model.Article.Title;
            existingArticle.Description = model.Article.Description;
            existingArticle.CategoryId = model.Article.CategoryId;
            existingArticle.CreatedDate = DateTime.Now;
            _articleService.TUpdate(existingArticle);

            var categoryList = _categoryService.TGetAll();
            model.CategoryList = categoryList.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }).ToList();
            model.CategoryList.Insert(0, new SelectListItem { Text = "Kategori seçiniz", Value = "" });

            return View(model);
        }
    }
}
