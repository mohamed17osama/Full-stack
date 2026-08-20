using First_API.Classes;
using Microsoft.AspNetCore.Mvc;

namespace First_API.interfaces
{
    public interface IProductsService
    {
        public Products CreateProduct(Products product);

        public List<Products> GetProducts();

        public Products GetProducts(int id);

        public void DeleteProduct(int id);

        public Products PutProduct(Products product, int id);
    }
}
