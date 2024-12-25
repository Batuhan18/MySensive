﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.EntityLayer.Entities
{
    public class Newsletter
    {
        [Key] 
        public int NewsletterId { get; set; }
        public string Email { get; set; }

    }
}
