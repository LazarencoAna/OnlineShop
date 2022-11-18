﻿using Microsoft.AspNetCore.Mvc;
using OnlineShop.BAL.Services.Products;
using OnlineShop.BAL.Services.Products.Models;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductsServices _productService;

        public ProductsController(IProductsServices productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> Get()
        {
            var products = await _productService.GetProductsAsync();
            return Ok(products);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductModel>> Get(int id)
        {
            var product = await _productService.GetProductAsync(id);
            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] ProductModel product)
        {
            var productId = await _productService.AddProductAsync(product);
            return Ok(productId);
        }

        // PUT api/<ProductsController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ProductModel product)
        {
            await _productService.EditProductAsync(product);
            return Ok();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok();
        }
    }
}
