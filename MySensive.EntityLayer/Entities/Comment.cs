using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.EntityLayer.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public int ArtcileId { get; set; }
        public virtual Article Article { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }

    }
}
