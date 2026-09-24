using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeAccessLayer;

namespace MVC_CRUD_Operations.Controllers
{
    public class EmployeeController : Controller
    {
        Service serve = new Service();
        // GET: Employee
        public ActionResult Index()
        {
            List<Model> lst = serve.GetEmployeeDetails();
            return View(lst);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            List<Model> lst = serve.GetEmployeeDetails();
            var result = lst.Where(n => n.Emp_ID == id).FirstOrDefault();
            return View(result);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeCreateModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    //Service accessLayer = new Service();
                    serve.InsertEmployee(model);
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            List<Model> lst = serve.GetEmployeeDetails();
            var result = lst.Where(x => x.Emp_ID == id).FirstOrDefault();
            return View(result);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Model model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Service service = new Service();
                    service.UpdateEmployee(model);
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var model = serve.GetEmployeeDetails();
            var results = model.Where(x => x.Emp_ID == id).FirstOrDefault();
            return View(results);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(Model model)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    serve.DeleteEmployee(model);
                    return RedirectToAction("Index");
                }               
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }
    }
}
