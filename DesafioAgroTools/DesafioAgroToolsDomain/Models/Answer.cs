using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioAgroToolsDomain.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public DateTime Dt_Register { get; set; }
        public Question Question { get; set; }

        public Answer()
        {

        }
        public Answer(string description, string lat, string @long, DateTime dt_Register, Question question)
        {
            Description = description;
            Lat = lat;
            Long = @long;
            Dt_Register = dt_Register;
            Question = question;
        }
    }
}
