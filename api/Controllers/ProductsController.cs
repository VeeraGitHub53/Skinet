using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastruture.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;
        public ProductsController(StoreContext context)
        {
          this.context = context;
        }

       [HttpGet("GetProducts")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
          var products=await context.Products.ToListAsync();          
          return products ;
        }

        //[Cached(600)]
        // [HttpGet("{id}")]
        // [ProducesResponseType(StatusCodes.Status200OK)]
       // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
       // public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        //  public async Task<ActionResult<string>> GetProduct(int id)
        // {
        //     // var spec = new ProductsWithTypesAndBrandsSpecification(id);

        //     // var product = await _productsRepo.GetEntityWithSpec(spec);

        //     // if (product == null) return NotFound(new ApiResponse(404));

        //     // return _mapper.Map<Product, ProductToReturnDto>(product);
        //     return "unk";
        // }
        
    }
}