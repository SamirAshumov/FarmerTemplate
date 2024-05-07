using Microsoft.AspNetCore.Mvc;
using Template.DAL;
using Template.Models;

namespace Template.Controllers
{
    public class TeamController : Controller
    {

        private readonly AppDbContext _dbContext;
        public TeamController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public IActionResult Index()
        {
           // Farmer farmer1 = new Farmer()
           // {
           //     Fullname = "Farmer no 1",
           //     Image = "team-1.jpg",
           //     Position = "Ordinary"
           // };

           // Farmer farmer2 = new Farmer()
           // {
           //     Fullname = "Farmer no 2",
           //     Image = "team-2.jpg",
           //     Position = "Ordinary"
           // };

           // Farmer farmer3 = new Farmer()
           // {
           //     Fullname = "Farmer no 3",
           //     Image = "team-3.jpg",
           //     Position = "Ordinary"
           // };

           // Farmer farmer4 = new Farmer()
           // {
           //     Fullname = "Farmer no 4",
           //     Image = "team-1.jpg",
           //     Position = "Ordinary"
           // };

           // Farmer farmer5 = new Farmer()
           // {
           //     Fullname = "Farmer no 5",
           //     Image = "team-2.jpg",
           //     Position = "Ordinary"
           // };

           // Farmer farmer6 = new Farmer()
           // {
           //     Fullname = "Farmer no 6",
           //     Image = "team-3.jpg",
           //     Position = "Ordinary"
           // };



           //List<Farmer> Farmers = new List<Farmer>() { farmer1, farmer2, farmer3, farmer4, farmer5, farmer6 };

           // _dbContext.Farmers.AddRange(Farmers);
           // _dbContext.SaveChanges();

            List<Farmer> Farmers = _dbContext.Farmers.ToList();


            return View(Farmers);
        }
    }
}
