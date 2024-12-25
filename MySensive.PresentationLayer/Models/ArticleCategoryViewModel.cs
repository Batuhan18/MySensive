using Microsoft.AspNetCore.Mvc.Rendering;
using MySensive.EntityLayer.Entities;

namespace MySensive.PresentationLayer.Models
{
    public class ArticleCategoryViewModel
    {
        public Article Article { get; set; }
        public Category Category { get; set; }
        public List<SelectListItem> CategoryList { get; set; }
    }
}
