using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.EntityLayer.Entities
{
    public class TagCloud
    {
        [Key]
        public int TagCloudId { get; set; }
        public string Title { get; set; }

    }
}
