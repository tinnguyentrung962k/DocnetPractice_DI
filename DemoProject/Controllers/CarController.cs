using DemoProject.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService) { 
            _carService = carService;
        }
        [HttpGet]
        [Route("/api/[controller]/get-all-cars")]
        public IActionResult GetAllCars() 
        {
            var carsList = _carService.GetAllCars();
            if (!carsList.Any()) 
            {
                return BadRequest("Empty List");
            }
            return Ok(carsList);
        }
        [HttpPost]
        [Route("/api/[controller]/add-new-car")]
        public IActionResult AddCar([FromBody] Car carModel)
        {
            if (carModel.ReleaseYear <= 0 || carModel.Price < 0)
            {
                return BadRequest("This car can't be added");
            }
            _carService.AddNewCar(carModel);
            return Ok(carModel);
        }
        
    }
}
