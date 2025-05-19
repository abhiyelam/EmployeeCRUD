//﻿using EmployeeCRUDapp.Models;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUDapp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeCrud crud;
       
        private readonly IConfiguration configuration;
        public EmployeeController( IConfiguration configuration)
        {
            this.configuration = configuration;
            crud = new EmployeeCrud(this.configuration);
           
        }
        // GET: EmoloyeeController
        public ActionResult EmpList()
        {
            
            var emp = crud.GetAllEmployess();
             return View(emp);
        }

        // GET: EmoloyeeController/Details/5
        public ActionResult Details(int id)
        {
            var emp = crud.GetEmployeeById(id);
            return View(emp);
        }

        // GET: EmoloyeeController/Create
       
        public ActionResult Create()
        {
             return View();
        }

        // POST: EmoloyeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {
                int result = crud.AddEmployee(emp);
                if(result==1)
                return RedirectToAction(nameof(EmpList));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: EmoloyeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var emp=crud.GetEmployeeById(id);
            return View(emp);
        }

        // POST: EmoloyeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            try
            {
                int result = crud.UpdateEmployee(emp);
                if (result == 1)
                    return RedirectToAction(nameof(EmpList));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: EmoloyeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var emp = crud.GetEmployeeById(id);
            return View(emp);
        }

        // POST: EmoloyeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName(nameof(Delete))]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = crud.DeleteEmployee(id);
                if (result == 1)
                    return RedirectToAction(nameof(EmpList));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
