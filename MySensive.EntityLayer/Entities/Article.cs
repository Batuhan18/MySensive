using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.EntityLayer.Entities
{
    public class Article
    {

        [Key]
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CoverImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int? UserId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public User User { get; set; }

    }
}
