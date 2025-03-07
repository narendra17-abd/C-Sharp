using EF_Code_First_Demo.Repositories;
using Microsoft.AspNetCore.Mvc;
using EF_Code_First_Demo.Model;

namespace EF_Code_First_Demo.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;


        public ProductsController(IProductRepository repo)

        {

            _productRepository = repo;


        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Products>>> GetAllProducts()

        {

            return Ok(await _productRepository.GetProductsAsync());

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Products>> GetProduct(int id)

        {

            var product = await _productRepository.GetProductByIdAsync(id);

            if (product == null)

            {

                return NotFound();

            }

            return product;

        }


        [HttpPost]

        public async Task<ActionResult<Products>> AddProduct(Products product)

        {

            var newProduct = await _productRepository.AddProductAsync(product);

            return CreatedAtAction(nameof(GetProduct), new { id = newProduct.Id }, newProduct);



        }

        [HttpPut("{id}")]

        public async Task<ActionResult> UpdateProduct(int id, [FromBody] Products updatedProduct)

        {

            var product = await _productRepository.UpdateProductAsync(id, updatedProduct);


            if (product == null)

            {

                return NotFound("Product not found"); // Return 404 Not Found

            }


            return NoContent(); // Return 204 No Content if successful

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> DeleteProduct(int id)

        {

            string result = await _productRepository.DeleteProductAsync(id);


            if (result == "Product not found")

            {

                return NotFound(result); // Return 404 Not Found if product does not exist

            }


            return Ok(result); // Return 200 OK with success message

        }
    }
}
