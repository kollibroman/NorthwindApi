using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Interfaces;

namespace NorthwindWebApi.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _service.GetCustomerDtos();
            return Ok(customers);
        }
        
    }
}