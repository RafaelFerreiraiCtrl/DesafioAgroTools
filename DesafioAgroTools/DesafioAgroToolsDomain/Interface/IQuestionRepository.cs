using DesafioAgroToolsDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAgroToolsDomain.Interface
{
    public interface IQuestionRepository
    {
        public void Add(Question question);
        public IEnumerable<Question> GetAllByQuestionary();
        public void SaveChanges();

    }
}
