using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            var model = _context.Items.ToList();
            return View("Index", model);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            //var item = _context.Items.FirstOrDefault(e => e.Id == id);
            _context.Items.Remove(_context.Items.FirstOrDefault(e => e.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
