using Juanprak.DAL;
using Juanprak.Models;
using Juanprak.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juanprak.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context; 
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Policy> policies = new List<Policy>
            {
                new Policy
                {
                    Id =1,
                    Title ="Salam",
                    Desc = "kjdfvnkfjvjf sdkjvfdlv klsvj",
                    Icon = "policy-1.png"

                },
                 new Policy
                 {
                    Id =1,
                    Title ="Hello",
                    Desc = "kjdfvnkfjvjf sdkjvfdlv klsvj",
                    Icon = "policy-2.png"

                 },
                  new Policy
                  {
                    Id =1,
                    Title ="Sagol",
                    Desc = "kjdfvnkfjvjf sdkjvfdlv klsvj",
                    Icon = "policy-3.png"

                  }
            };
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = sliders,
                Policies = policies
            };
            return View(homeVM);
        }
    }
}
