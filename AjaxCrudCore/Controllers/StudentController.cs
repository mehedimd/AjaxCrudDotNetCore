using AjaxCrudCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxCrudCore.Controllers
{
    public class StudentController : Controller
    {
        private MyContext context;
        public StudentController(MyContext ctx)
        {
            this.context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        // get all
        public JsonResult Get()
        {
            var allData = context.Students.ToList();
            return Json(allData);
        }
        // post
        public JsonResult Post (Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                if (context.SaveChanges() > 0)
                {
                    return Json(true);
                }
            }
            return Json(false);
        }
        // edit get
        public JsonResult Edit(int id)
        {
            var data = context.Students.Find(id);
            return Json(data);
        }
        // update 
        public JsonResult Update(Student student)
        {
            context.Students.Update(student);
            if (context.SaveChanges() > 0)
            {
                return Json(true);
            } ;
            return Json(false);
        }
        // delete
        public JsonResult Delete(int id)
        {
            context.Students.Remove(context.Students.Find(id));
            if (context.SaveChanges() > 0)
            {
                return Json(true);
            }
            return Json(false);

        }
    }
}
