using First_API.Classes;
using First_API.interfaces;
using First_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [ApiController]
    [Route("/api")] // https://localhost:7025/api
    public class ProductsController: ControllerBase
    {
        private IProductsService _productService;
        public ProductsController(IProductsService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public ActionResult CreateProduct(Products product)
        {
            var newProduct = _productService.CreateProduct(product);
            
            return Created($"/api/product/{newProduct.Id}", newProduct);

        }
        [HttpGet]
        public ActionResult<List<Products>> GetProducts()
        {
            return Ok(_productService.GetProducts());
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult GetProduct(int id)
        {
            Products product = _productService.GetProducts(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return Accepted();
        }
        [HttpPut]
        [Route("{id}")]
        public ActionResult PutProduct(Products product,int id)
        {
            return Ok(_productService.PutProduct(product, id));
        }
    }
}
