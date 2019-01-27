using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace WebApis.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //public Student Get()
        //{
        //    var query = new Student();
        //    using (VasuDbEntities entity = new VasuDbEntities())
        //    {
        //        //var query = from th in entity.Students
        //        //            select th;

        //        //return query.ToList();
        //        query = from th in entity.Students.Include(t => t.Name)
        //                    select th;
               
        //    }
        //    return query;
        //}
        public String Getting(int id)
        {
            using (VasuDbEntities entity = new VasuDbEntities())
            {
                //var query = entity.Students.Where(th => th.StudentId == id).FirstOrDefault();
                //return query.Name;
                var store= entity.Students.FirstOrDefault(e => e.StudentId == id);
                return store.Name;
            }
        }
    }
}