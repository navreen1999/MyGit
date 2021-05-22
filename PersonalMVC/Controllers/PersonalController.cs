using EmployeeMVC.Models;
using EmployeeMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Controllers
{
    public class PersonalController : Controller
    {
        private IRepo<Personal> _repo;
        private ILogger<PersonalController> _logger;

        public PersonalController(IRepo<Personal> repo,ILogger<PersonalController> logger)
        {
            _repo = repo;
            _logger = logger;

        }
        public IActionResult Index()
        {
            List<Personal> personals = _repo.GetAll().ToList();
            return View(personals);
         
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Personal personal)
        {
            _repo.Add(personal);

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Personal personal= _repo.Get(id);
            return View(personal);
        }
        [HttpPost]
        public IActionResult Edit(int id, Personal personal)
        {
            _repo.Update(id, personal);

            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Personal personal = _repo.Get(id);
            return View(personal);
        }
        
        public IActionResult Delete(int id) 
        {
            Personal personal = _repo.Get(id);
            return View(personal);
        }
        [HttpPost
            ]
        public IActionResult Delete(Personal personal)
        {
            _repo.Delete(personal);
            return RedirectToAction("Index");
        }
    }
}
