using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Interview_C_Sharp.Data;
using MVC_Interview_C_Sharp.Models.DataModels;

namespace MVC_Interview_C_Sharp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test(Customer customer)
        {
            return View();        
        }
    }
}
