using DesafioAgroToolsDomain.Interface;
using DesafioAgroToolsDomain.Models;
using DesafioAgroToolsInfra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAgroToolsInfra.Repository
{
    public class QuestionaryRepository : IQuestionaryRepository
    {
        protected ApplicationContext _context;
        public QuestionaryRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void Add(Questionary questionary)
        {
            questionary.Dt_register = DateTime.Now;
            _context.Add(questionary);
        }

        public Questionary GetById(int id)
        {
            var questionary = _context.Questionary.Find(id);
            return questionary;
        }

        public IEnumerable<Questionary> GetAll()
        {
            return _context.Questionary;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
