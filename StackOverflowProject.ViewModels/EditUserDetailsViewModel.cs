﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowProject.ViewModels
{
    public class EditUserDetailsViewModel
    {

        [Required]
        [RegularExpression(@"(\w+@[a-zA-Z_]+?\.[a-zA_Z]{2-6})")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]*$")]
        public string Name { get; set; }

        [Required]
        public string Mobile { get; set; }

    }
}
