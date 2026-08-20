using First_API.Classes;

namespace First_API.interfaces
{
    public interface IProductRepository
    {
        public Products CreateProduct(Products product);

        public List<Products> GetProducts();

        public Products GetProducts(int id);

        public void DeleteProduct(int id);

        public Products PutProduct(Products product, int id);
    }
}
