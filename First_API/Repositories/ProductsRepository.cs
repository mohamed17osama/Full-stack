using First_API.Classes;
using First_API.interfaces;

namespace First_API.Repositories
{
    public class ProductsRepository:IProductRepository
    {
        private List<Products> _products = new List<Products>();
        public Products CreateProduct(Products product)
        {
            _products.Add(product);
            return product;
        }

        public List<Products> GetProducts()
        {
            return _products;
        }
        public Products GetProducts(int id)
        {
            Products product = null;
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == id)
                {
                    product = _products[i];
                }
            }
            return product;
        }

        public void DeleteProduct(int id)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == id)
                {
                    _products.Remove(_products[i]);
                }
            }
        }

        public Products PutProduct(Products product, int id)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == id)
                {
                    _products.Remove(_products[i]);
                    _products.Add(product);
                }
            }
            return product;
        }
    
    }
}
