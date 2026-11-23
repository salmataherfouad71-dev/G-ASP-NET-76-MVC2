using Assignment._21.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment._21.Controllers
{
    public class PlansController:Controller
    {
        public IActionResult Test ()
        {
            return View();
        }
        public async Task <IActionResult> Index()
        { 
            using GymDbContext context=new GymDbContext();
            var plans = await context.Plans.ToListAsync();
            return View(plans);
        }
    }
}
