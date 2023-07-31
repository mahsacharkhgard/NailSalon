using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reservation.Application.Contract.Dtos.Personnels;
using Reservation.Application.Contract.IServices.IPersonnels;
using Reservation.EndPoint.API.Filters;

namespace Reservation.EndPoint.API.Controllers
{
    [SecurityFilter("Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelsController : ControllerBase
    {
        private readonly IPersonnelService personnelService;
        public PersonnelsController(IPersonnelService personnelService)
        {
            this.personnelService = personnelService;

        }

        [HttpPost]
        public IActionResult Add([FromForm] PersonnelAddDto dto)
        {
            personnelService.Add(dto);
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


        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(personnelService.GetAll().ToList());
        }
    }
}

