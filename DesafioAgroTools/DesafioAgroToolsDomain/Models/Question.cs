﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioAgroToolsDomain.Models
{
    public class Question
    { 
        public Question()
        {

        }

        public Question(string description, int questionary)
        {
            Description = description;
            QuestionId = questionary;
        }
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }


        [ForeignKey("Questionary")]
        public int? QuestionId { get; set; }
        public virtual Questionary Questionary { get; set; }

       
    }
}
