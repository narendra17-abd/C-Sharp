using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Repo_Pattern.Data;
using Repo_Pattern.Model;
using Repo_Pattern.Repositories;

namespace Repo_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;


        public ProductsController(IProductRepository repo)

        {

            _productRepository = repo;


        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()

        {

            return Ok(await _productRepository.GetProductsAsync());

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Product>> GetProduct(int id)

        {

            var product = await _productRepository.GetProductByIdAsync(id);

            if (product == null)

            {

                return NotFound();

            }

            return product;

        }


        [HttpPost]

        public async Task<ActionResult<Product>> AddProduct(Product product)

        {

            var newProduct = await _productRepository.AddProductAsync(product);

            return CreatedAtAction(nameof(GetProduct), new { id = newProduct.Id }, newProduct);



        }

        [HttpPut("{id}")]

        public async Task<ActionResult> UpdateProduct(int id, [FromBody] Product updatedProduct)

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
