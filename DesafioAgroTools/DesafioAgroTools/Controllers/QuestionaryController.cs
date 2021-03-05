using DesafioAgroToolsDomain.Models;
using DesafioAgroToolsDomain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAgroTools.Controllers
{
    public class QuestionaryController : Controller
    {
        private QuestionaryService _questionaryService;
        public QuestionaryController(QuestionaryService questionaryService)
        {
            _questionaryService = questionaryService;
        }
        // GET: QuestionaryController
        public ActionResult Index()
        {

            //Acessar o domain e trazer a lista de Models
            //var models = _questionaryDomain.GetAllQuestionaries();
            //return View(models);

            
            return View(_questionaryService.GetAll());
        }

        // GET: QuestionaryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionaryController/Create
        public ActionResult Create()
        {
            
            return View(new Questionary());
        }

        // POST: QuestionaryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Questionary questionary)
        {
            
            try
            {
                _questionaryService.Add(questionary);
                TempData["IdQuestionary"] = questionary.Id;
                return RedirectToAction("Create","Question");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionaryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionaryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionaryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionaryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
