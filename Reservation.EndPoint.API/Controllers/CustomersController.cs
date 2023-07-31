using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.Application.Contract.Dtos.Customers;
using Reservation.Application.Contract.Dtos.NailServices;
using Reservation.Application.Contract.IServices.ICustomers;
using Reservation.Model.Models;

namespace Reservation.EndPoint.API.Controllers
{
    [Authorize("Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;
        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
            
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Add([FromForm] CustomerAddDto dto)
        {
            customerService.Add(dto);
            return Created("", dto);
        }

        
        [HttpPut]
        public IActionResult Update(int customerId)
        {
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int customerId)
        {
            return Ok();
        }

        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(customerService.GetAll());
        }
    }
}
