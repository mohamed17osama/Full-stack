using First_API.Classes;
using First_API.interfaces;
using First_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Services
{
    public class ProductService:IProductsService
    {
        private IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
        public Products CreateProduct(Products product)
        {
            return _repo.CreateProduct(product);
        }
        public List<Products> GetProducts()
        {
            return _repo.GetProducts();
        }
        public Products GetProducts(int id)
        {
            return _repo.GetProducts(id);
        }
        public void DeleteProduct(int id)
        {
            _repo.DeleteProduct(id);
        }

        public Products PutProduct(Products product, int id)
        {
            return _repo.PutProduct(product, id);
        }
    }
}
