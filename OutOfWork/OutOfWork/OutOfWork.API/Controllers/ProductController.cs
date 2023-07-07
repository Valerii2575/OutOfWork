using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OutOfWork.Core.Models;
using OutOfWork.Services.Interfaces;

namespace OutOfWork.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsList()
        {
            var products = await _productService.GetAllProductsAsync();

            return Ok(products);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(int productId)
        {
            var product = await _productService.GetProductByIdAsync(productId);
            return Ok(product);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDetails product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isProductCreated = await _productService.CreateProductAsync(product);
            return Ok(isProductCreated);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductDetails product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isUpdate = await _productService.UpdateProductAsync(product);
            return Ok(isUpdate);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            var isDeleted = await _productService.DeleteProductAsync(productId);

            return isDeleted ? Ok(isDeleted) : BadRequest(isDeleted);
        }
    }
}