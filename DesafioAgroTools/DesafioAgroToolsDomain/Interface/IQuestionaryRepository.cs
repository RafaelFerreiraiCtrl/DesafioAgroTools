using DesafioAgroToolsDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAgroToolsDomain.Interface
{
    public interface IQuestionaryRepository
    {
        public void Add(Questionary questionary);

        public Questionary GetById(int id);

        public IEnumerable<Questionary> GetAll();

        public void SaveChanges();
  
    }
}
