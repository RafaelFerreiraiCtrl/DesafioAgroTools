using DesafioAgroToolsDomain.Interface;
using DesafioAgroToolsDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioAgroToolsDomain.Service
{
    public class QuestionaryService
    {
        private readonly IQuestionaryRepository _iQuestionaryRepository;
        public QuestionaryService(IQuestionaryRepository iquestionaryRepository)
        {
            _iQuestionaryRepository = iquestionaryRepository;
        }
        public void Add(Questionary questionary)
        {
            _iQuestionaryRepository.Add(questionary);
            _iQuestionaryRepository.SaveChanges();
        }

        public List<Questionary> GetAll()
        {
            return _iQuestionaryRepository.GetAll().ToList();
        }



    }
}
