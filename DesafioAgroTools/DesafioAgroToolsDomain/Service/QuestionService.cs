using DesafioAgroToolsDomain.Interface;
using DesafioAgroToolsDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioAgroToolsDomain.Service
{
    class QuestionService
    {

        private readonly IQuestionRepository _iQuestionRepository;
        public QuestionService(IQuestionRepository iquestionRepository)
        {
            _iQuestionRepository = iquestionRepository;
        }
        public void Add(Question questionary)
        {
            _iQuestionRepository.Add(questionary);
            _iQuestionRepository.SaveChanges();
        }

        public List<Question> GetAllByQuestionary()
        {
            return _iQuestionRepository.GetAllByQuestionary().ToList();
        }
    }
}
