﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Genre: BaseClass
    {
        [Required(ErrorMessage ="Name is a required field")]
        [MaxLength(30, ErrorMessage ="Maximum Length for name is 30 characters")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage ="Description is a required field")]
        public string Description { get; set; } = string.Empty;
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
