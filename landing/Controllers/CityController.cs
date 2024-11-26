using landing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace landing.Controllers
{
    public class CityController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Index()
        {
            var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "cities.json");
            var jsonData = System.IO.File.ReadAllText(jsonFilePath , System.Text.Encoding.UTF8);
            var cities = JsonConvert.DeserializeObject<List<City>>(jsonData);
            return new JsonResult(cities)
            {
                ContentType = "application/json; charset=utf-8"
            };
             
        }

    }
}
