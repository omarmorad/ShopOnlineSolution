﻿using Microsoft.AspNetCore.Mvc;
using ShopOnline.API.Extensions;
using ShopOnline.API.Repositories.Contracts;

using ShopOnline.Models.Dtos;

namespace ShopOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {

            try
            {
                var products = await this.productRepository.GetItems();
                var productCategories = await this.productRepository.GetCategories();
                if (products == null || productCategories == null)
                {
                    return NotFound();
                }
                else 
                {
                    var productsDtos = products.ConverttoDto(productCategories);
                    return Ok(productsDtos);
                }

                     
            } 
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the databse");
            }
        }
    }
}
