using DesafioAgroToolsDomain.Models;
using DesafioAgroToolsInfra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAgroTools.Controllers
{
    public class QuestionController : Controller
    {
        ApplicationContext _context;
        public QuestionController(ApplicationContext context)
        {
            _context = context;
        }
        // GET: QuestionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuestionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            var idQuestionary = (int)TempData["IdQuestionary"];
            ViewBag.IdQuestionary = idQuestionary;
            var questionsAdicionadas = _context.Question.Where(x => x.QuestionId == idQuestionary).ToList();
            return View(questionsAdicionadas);
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Question question)
        {
            try
            {
                _context.Add(question);
                _context.SaveChanges();
                var questionsAdicionadas = _context.Question.Where(x => x.QuestionId == question.QuestionId).ToList();
                return View(questionsAdicionadas);
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionController/Edit/5
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

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionController/Delete/5
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
