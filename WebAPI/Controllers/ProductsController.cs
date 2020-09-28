using Application.Product.Commands;
using Application.Product.DTOs;
using Application.Product.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [ProducesResponseType(typeof(IEnumerable<ProductDto>), (int)HttpStatusCode.OK)]
        [HttpGet("all/{search?}")]
        public async Task<IActionResult> Get(string search)
        {
            var command = new GetAllProductsQuery()
            {
                Search = search ?? string.Empty
            };

            var products = await _mediator.Send(command);

            return Ok(products);
        }

        [ProducesResponseType(typeof(ProductDto), (int)HttpStatusCode.OK)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var product = await _mediator.Send(new GetProductByIdQuery(id));
                return Ok(product);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {
            var id = await _mediator.Send(command);

            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, UpdateProductCommand command)
        {
            if (id != command.Id) return BadRequest();

            await _mediator.Send(command);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _mediator.Send(new DeleteProductCommand(id));

            return Ok();
        }
    }
}
