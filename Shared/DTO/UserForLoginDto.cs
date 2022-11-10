﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserForLoginDto
    {
        [Required(ErrorMessage ="Username is a required field")]
        public string? UserName { get; set; }
        [Required(ErrorMessage ="Password is a required field")]
        public string? Password { get; set; }
    }
}
