using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SongzManager.DataManager;
using SongzManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SongzManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMusicManager _musicManager;
        public HomeController(ILogger<HomeController> logger,IMusicManager musicManager)
        {
            _musicManager = musicManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _musicManager.Notify = new Notifier();
            var songs = _musicManager.GetMusicThenNotify();
            return View(songs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
