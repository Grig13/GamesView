using GamesView.Models;
using GamesView.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GamesView.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Review> reviewsList = _reviewRepository.GetAll();
            return View(reviewsList);
        }

        public IActionResult CreateReview()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReview(Review reviews)
        {
            _reviewRepository.Create(reviews);
            return RedirectToAction("Index");
        }
    }
}
