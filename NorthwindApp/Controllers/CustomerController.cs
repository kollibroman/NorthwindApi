using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindApp.Models.UpdateDto;

namespace NorthwindApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly Northwind _dbcontext;
        private readonly IMapper _mapper;
        public CustomerController(Northwind dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            var customers = _dbcontext.Customers.ToList();
            var customerDtos = _mapper.Map<List<CustomerDto>>(customers);
            return Ok(customerDtos);
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<CustomerDto> GetCustomerById([FromRoute]string id)
        {
            var customer = _dbcontext.Customers.FirstOrDefault(c => c.CustomerId == id);

            if (customer is null)
            {
                return BadRequest();
            }

            var customerDto = _mapper.Map<CustomerDto>(customer);
            return Ok(customerDto);
        }

        [HttpPost]
        public ActionResult CreateCustomer([FromBody] CreateCustomerDto dto)
        {
            var customer = _mapper.Map<Customer>(dto);
            _dbcontext.Customers.Add(customer);
            _dbcontext.SaveChanges();
            return Created($"/api/customer/{customer.CustomerId}", null);
        }

        // [HttpPut("{id}")]
        // public ActionResult UpdateCustomer([FromRoute]string customerId,[FromBody] UpdateCustomerDto dto)
        // {
        //     var customer = _dbcontext.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            
        //     if(customer is null)
        //     {
        //         return NotFound();
        //     }

        //     var updatedCustomer = _mapper.Map<Customer>();
        //     _dbcontext.Update(updatedCustomer);
        //     _dbcontext.SaveChanges();
        //     return Ok($"Resurce with id: {customerId} has been succesfully updated");
        // }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteCustomer([FromRoute]string customerId)
        {
            var customer = _dbcontext.Customers.FirstOrDefault(c => c.CustomerId == customerId);

            if (customer is null)
            {
                return BadRequest();
            }

            _dbcontext.Customers.Remove(customer);
            _dbcontext.SaveChanges();
            return Ok($"Resource with id: {customerId} has been deleted");
        }
    }
}