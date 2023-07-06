using AwesomeShop.Services.Products.Application.Commands.Products.AddCommand;
using AwesomeShop.Services.Products.Application.Commands.Products.UpdateCommand;
using AwesomeShop.Services.Products.Application.Queries.Products.GetAllQuery;
using AwesomeShop.Services.Products.Application.Queries.Products.GetByIdQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeShop.Services.Products.Api.Controllers;

public class ProductController
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductsQueryInputModel();

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQueryInputModel(id);

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddProductCommandInputModel command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateProductCommandInputModel command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}