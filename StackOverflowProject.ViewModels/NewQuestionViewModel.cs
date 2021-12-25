﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowProject.ViewModels
{
    public class NewQuestionViewModel
    {
        [Required]
        public string QuestionName { get; set; }

        [Required]
        public DateTime QuestionDateAndTime { get; set; }


        [Required]
        public int UserID { get; set; }
        
        [Required]
        public int CategorgyID { get; set; }
        
        [Required]
        public int VotesCount { get; set; }
        
        [Required]
        public int AnswersCOunt { get; set; }
        
        [Required]
        public int ViewsCount { get; set; }

    }
}
