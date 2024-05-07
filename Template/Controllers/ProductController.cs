using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template.DAL;
using Template.Models;

namespace Template.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {

            //Product product1 = new Product()
            //    {
            //        Name = "Apple",
            //        Image = "Apple.png",
            //        Price = 6.70
            //    };

            //    Product product2 = new Product()
            //    {
            //        Name = "Carrot",
            //        Image = "Carrot.png",
            //        Price = 7.20
            //    };


            //    Product product3 = new Product()
            //    {
            //        Name = "Apricot",
            //        Image = "Apricot.png",
            //        Price = 9.85
            //    };


            //    List<Product> Products = new List<Product>() { product1, product2, product3 };

            //    _dbContext.Products.AddRange(Products);
            //    _dbContext.SaveChanges();







            List<Product> Products = _dbContext.Products.ToList();



            return View(Products);
        }
    }
}
