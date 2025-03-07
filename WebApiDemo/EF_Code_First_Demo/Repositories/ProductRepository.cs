using EF_Code_First_Demo.Data;
using EF_Code_First_Demo.Model;
using Microsoft.EntityFrameworkCore;
using EF_Code_First_Demo.Model;

namespace EF_Code_First_Demo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;


        public ProductRepository(AppDbContext context)

        {

            _context = context;

        }


        public async Task<IEnumerable<Products>> GetProductsAsync()

        {

            return await _context.Products.ToListAsync();

        }


        public async Task<Products> GetProductByIdAsync(int id)

        {

            return await _context.Products.FindAsync(id);

        }


        public async Task<Products> AddProductAsync(Products product)

        {

            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            return product;

        }


        public async Task<Products> UpdateProductAsync(int id, Products product)

        {

            var updateProduct = await _context.Products.FindAsync(id);

            if (updateProduct == null)

            {

                return null; 

            }


            updateProduct.Name = product.Name;

            updateProduct.Price = product.Price;


            await _context.SaveChangesAsync();

            return updateProduct; 

        }


        public async Task<string> DeleteProductAsync(int id)

        {

            var prodcut = await _context.Products.FindAsync(id);

            if (prodcut != null)

            {

                _context.Remove(prodcut);

                await _context.SaveChangesAsync();

                return "Product Removed Successfully";

            }

            else

                return "Product not found";

        }

        Task<IEnumerable<Products>> IProductRepository.GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        Task<Products> IProductRepository.GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        //public Task<Products> AddProductAsync(Products product)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Products> UpdateProductAsync(int id, Products product)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
