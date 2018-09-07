using Knowledge_MVC5_Example01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Knowledge_MVC5_Example01.Controllers
{
    public class ProductsController : Controller
    {
        public ViewResult List()
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, Name = "BIC Crystal - Blue", Type = "Pens"    },
                new Product() { Id = 2, Name = "Pilot - Black",      Type = "Pens"    },
                new Product() { Id = 3, Name = "Faber-Castell 2B",   Type = "Pencils" }
            };

            return View(products);
        }
    }
}
