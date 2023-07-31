using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reservation.Application.Contract.Dtos.NailServices;
using Reservation.Application.Contract.IServices.INailServices;
using Reservation.Model.Models;

namespace Reservation.EndPoint.API.Controllers
{
    [Authorize("Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class NailServicesController : ControllerBase
    {
        private readonly INailServiceService nailServiceService;
        

        public NailServicesController(INailServiceService nailServiceService)
        {
            this.nailServiceService = nailServiceService;
        }

        
        [HttpPost]
        public IActionResult Add([FromForm] NailServiceAddDto dto)
        {
            nailServiceService.Add(dto);
            return Created("", dto);
        }

        
        [HttpPut]
        public IActionResult Update(int nailServiceId)
        {
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAll(int take)
        {
            return Ok(nailServiceService.GetAll());
        }

        [AllowAnonymous]
        [HttpGet("{take}")]
        public IActionResult GetTop(int take)
        {
            return Ok(nailServiceService.GetTop(take));
        }

        [AllowAnonymous]
        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            var nailService = new NailService();
            return Ok(nailServiceService.GetByName(new SearchNailServiceRequestDto
            {
                Id = nailService.Id,
                ServiceName = nailService.ServiceName,
                UnitPrice = nailService.UnitPrice
            })
            );
        }
    }
}
