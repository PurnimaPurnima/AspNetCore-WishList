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
            return View("Index");
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            RedirectToAction("Index");
            return View();
        }

        public IActionResult Delete(int Id)
        {
            RedirectToAction("Index");
            return View();
        }
    }

}
