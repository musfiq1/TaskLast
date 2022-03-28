using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaskLast.Data;
using TaskLast.Models;

namespace TaskLast.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult FirstTask()
        {
            return View();
        }

        public IActionResult SecondTask(int id)
        {
            var tasksList = _context.SecondTables.Where(x => x.FirstTableId == id);
            return View(tasksList);
        }


        public IActionResult Chekbox(int SecondTableId)
        {
            var todos = _context.SecondTables.FirstOrDefault(x => x.ID == SecondTableId);
            todos.IsDone = true;
            _context.SaveChanges();
            CheckCount(todos.FirstTableId);




            /*
            var num = model2.IsDone;
            if (model.IsDone == true)
            {

            }*/
            return View();
        }

        private void CheckCount(int FirstTableId)
        {
            var items = _context.SecondTables.Where(x => x.FirstTableId == FirstTableId).ToList();
            if (items.Count() == items.Where(x => x.IsDone == true).Count())
            {
                _context.FirstTables.FirstOrDefault(x => x.ID == FirstTableId).IsDone = true;
                _context.SaveChanges();
            }
        }


    }
}
