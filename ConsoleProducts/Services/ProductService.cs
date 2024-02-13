using ConsoleProducts.Models;
using ConsoleProducts.Repositories;

namespace ConsoleProducts.Services
{
    internal class ProductService
    {
        private IRepository<Product> _repository; 

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public List<Product> GetProducts() => _repository.getAll();

        public void addProduct(Product product)
        {
            _repository.add(product);
        }
        
    }
}
