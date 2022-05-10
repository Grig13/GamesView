using GamesView.Models;
using GamesView.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GamesView.Controllers
{
    public class NewsController : Controller
    {

        private readonly INewsRepository _NewsRepository;

        public NewsController(INewsRepository NewsRepository)
        {
            _NewsRepository = NewsRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<News> newsList = _NewsRepository.GetAll();
            return View(newsList);
        }


        public IActionResult CreateNews()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNews(News news)
        {
            _NewsRepository.Create(news);
            return RedirectToAction("Index");
        }
    }
}
