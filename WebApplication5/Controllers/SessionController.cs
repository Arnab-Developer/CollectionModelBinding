using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            var s = new Session()
            {
                Id = 1,
                Name = "session1",
                Students = new List<Student>()
                {
                    new Student()
                    {
                        Id = 1,
                        Name = "student1"
                    },
                    new Student()
                    {
                        Id = 2,
                        Name = "student2"
                    }
                }
            };
            return View(s);
        }

        public IActionResult Create(Session s)
        {
            return View();
        }
    }
}
