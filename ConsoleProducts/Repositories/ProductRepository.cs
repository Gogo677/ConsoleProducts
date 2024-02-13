using ConsoleProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProducts.Repositories
{
    internal class ProductRepository : IRepository<Product>
    {
        private List<Product> _products;

        public ProductRepository() {
            _products = new List<Product>();
        }

        public Product add(Product newProduct)
        {
            _products.Add(newProduct);
            return newProduct;
        }

        public Boolean delete(int id)
        {
            foreach (Product product in _products)
            {
                if (product.Id == id)
                {
                    _products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public Product get(int id)
        {
            foreach (Product product in _products)
            {
                if (id == product.Id) return product;
            }
            return null;
        }

        public List<Product> getAll()
        {
            return _products;
        }

        public Boolean update(Product toUpdateProduct)
        {
            foreach(Product product in _products)
            {
                if (toUpdateProduct.Id == product.Id)
                {
                    _products.Remove(product);
                    _products.Add(toUpdateProduct);
                    return true;
                }
            }
            return false;
        }
    }
}
