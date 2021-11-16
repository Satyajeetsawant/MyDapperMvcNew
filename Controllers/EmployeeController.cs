using MyDapperMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyDapperMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeesRepository repository;
        // GET: Employee

        public EmployeeController()
        {
            repository = new EmployeesRepository();
        }
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View(repository.Get(id));
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {

                    repository.Create(emp);

                    ViewBag.Message = "Records added successfully.";
                    return RedirectToAction("Index");
                }

            return View();

            
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repository.Get(id));    
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            
                return View(repository.Update(emp));
            
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repository.Get(id));
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee emp)
        {
            
            
                // TODO: Add delete logic here
                repository.Delete(emp.Id);
                return RedirectToAction("Index");
            
        }
    }
}
