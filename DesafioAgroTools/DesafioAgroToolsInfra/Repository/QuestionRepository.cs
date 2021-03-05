using DesafioAgroToolsDomain.Interface;
using DesafioAgroToolsDomain.Models;
using DesafioAgroToolsInfra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAgroToolsInfra.Repository
{
    class QuestionRepository : IQuestionRepository
    {
        protected ApplicationContext _context;
        public QuestionRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void Add(Question question)
        {
            _context.Add(question);
        }

        public IEnumerable<Question> GetAllByQuestionary()
        {
            return _context.Question;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
