using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeOpeningQuiz.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimeOpeningQuiz.Controllers
{
    public class GameController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Game game)
        {
            return View();
        }
    }
}