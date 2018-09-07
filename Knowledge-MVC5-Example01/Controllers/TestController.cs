using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Knowledge_MVC5_Example01.Controllers
{
    public class TestController : Controller
    {
        public string Ping()
        {
            return "Pong";
        }
    }
}
