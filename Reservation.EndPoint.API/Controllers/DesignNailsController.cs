using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reservation.Application.Contract.Dtos.DesignNails;
using Reservation.Application.Contract.IServices.IDesignNails;

namespace Reservation.EndPoint.API.Controllers
{
    [Authorize("Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class DesignNailsController : ControllerBase
    {
        private readonly IDesignNailService designNailAdminService;

        public DesignNailsController(IDesignNailService designNailAdminService)
        {
            this.designNailAdminService = designNailAdminService;
        }

        [HttpPost]
        public IActionResult Add([FromForm] DesignNailAddDto dto)
        {
            designNailAdminService.Add(dto);
            return Created("", dto);
        }


        [HttpPut]
        public IActionResult Update(int designNailId)
        {
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int designNailId)
        {
            return Ok();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(designNailAdminService.GetAll());
        }
    }
}
