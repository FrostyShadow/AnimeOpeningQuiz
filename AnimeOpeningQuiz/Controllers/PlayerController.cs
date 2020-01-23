using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeOpeningQuiz.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimeOpeningQuiz.Controllers
{
    public class PlayerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Player joinGame)
        {
            return View();
        }
    }
}