﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.EntityLayer.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public bool Status { get; set; }

    }
}
