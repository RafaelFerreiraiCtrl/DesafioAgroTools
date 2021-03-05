

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioAgroToolsDomain.Models
{
    public class Questionary
    {
        [Key]
        public int Id { get; set; }
        public string Title{ get; set; }
        public string User{ get; set; }
        public DateTime Dt_register{ get; set; }

        public ICollection<Question> Question { get; set; }

        public Questionary()
        {
            Question = new HashSet<Question>();
        }
        public Questionary(string title, string user, DateTime dt_register)
        {
            Title = title;
            User = user;
            Dt_register = dt_register;
        }

    }
}
