using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;
using StackExchange.Redis;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        static ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
        IDatabase db = redis.GetDatabase();
        public IActionResult Index()
        {
            return View();
        }
        [Route("/{url}")]
        public IActionResult Index(string url)
        {
            if (db.KeyExists(url))
            {
                return RedirectPermanent(db.StringGet(url));
            }
            return View();
        }
       
      
        [HttpPost]
        public IActionResult ReductionURLPost()
        { 
            string URL = Request.Form.FirstOrDefault(p => p.Key == "URL").Value;
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string newURL = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
            db.StringSet(newURL, URL);
            db.KeyExpire(newURL, new TimeSpan(0, 0, 30)); // 30 сек
            ViewData["URL"] = newURL;
            return View();
        } 
    } 
}

