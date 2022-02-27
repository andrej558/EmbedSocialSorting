using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ReviewDbContext _reviewDbContext;

        

        private readonly ReaderJson jsonReader = new ReaderJson();

        public HomeController(ILogger<HomeController> logger, ReviewDbContext reviewDbContext)
        {
            _logger = logger;
            _reviewDbContext = reviewDbContext;

            

                if (_reviewDbContext.reviews.Count() == 0)
                {
                    
                    string rootPath = Directory.GetCurrentDirectory();

                    string fullPath = Path.Combine(rootPath, "wwwroot\\reviews.json");


                    var reviews = jsonReader.GetData(fullPath);


                    foreach (var review in reviews)
                    {

                        _reviewDbContext.reviews.Add(review);

                        
                        _reviewDbContext.SaveChanges();
                    }
                }

        }

        [HttpGet]
        public IActionResult Index([FromQuery]int minRating, [FromQuery] string prioText, [FromQuery] string orderRating, [FromQuery] string orderDate)
        {

            var reviews = _reviewDbContext.reviews.Where(z => z.rating >= minRating).ToList();

            if (orderDate == "Newest")
            {
                reviews = reviews.OrderByDescending(z => z.reviewCreatedOnDate).ToList();
            }
            else if (orderDate == "Oldest") { 
                reviews = reviews.OrderBy(z => z.reviewCreatedOnDate).ToList();   
            }

            if (orderRating == "Highest")
            {
                reviews = reviews.OrderByDescending(s => s.rating).ToList();
            }
            else if (orderRating == "Lowest")
            {
                reviews = reviews.OrderBy(s => s.rating).ToList();
            }

            if (prioText == "Yes")
            {
                reviews = reviews.OrderByDescending(s => s.reviewText).ToList();
            }



            return View(reviews);
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
