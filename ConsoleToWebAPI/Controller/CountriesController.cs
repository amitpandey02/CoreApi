using ConsoleToWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        // //[BindProperty(SupportsGet =true)] for Get Request we have to do like this
        // [BindProperty]
        // public string Name  { get; set; }
        // [BindProperty]
        // public int id { get; set; }
        // [BindProperty]
        // public string country { get; set; }
        // [BindProperty]
        // public string city { get; set; }

        // [HttpPost("")]
        //// [HttpGet("")]

        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute] int id)
        {
            return Ok($"id={id}"); 
        }

        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomModelBinder))]string[] countries)
        {
            return Ok(countries);
        }

        [HttpGet("")]
        public IActionResult GetName([FromServices] IProductRepository _productRepository)
        {
            var products = _productRepository.GetName();
            return Ok(products);
        }
    }
}
