using Application.Brand.Commands;
using Application.Brand.DTOs;
using Application.Brand.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(typeof(IEnumerable<BrandDto>), (int)HttpStatusCode.OK)]
        [HttpGet("all/{search?}")]
        public async Task<IActionResult> Get(string search)
        {
            var command = new GetAllBrandsQuery()
            {
                Search = search ?? string.Empty
            };

            var brands = await _mediator.Send(command);
            return Ok(brands);
        }

        [ProducesResponseType(typeof(BrandDto), (int)HttpStatusCode.OK)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var brands = await _mediator.Send(new GetBrandByIdQuery(id));
                return Ok(brands);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateBrandCommand command)
        {
            var brands = await _mediator.Send(command);
            return Ok(brands);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, UpdateBrandCommand command)
        {
            if (id != command.Id) return BadRequest();

            var brands = await _mediator.Send(command);
            return Ok(brands);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var brands = await _mediator.Send(new DeleteBrandCommand(id));
            return Ok(brands);
        }
    }
}
