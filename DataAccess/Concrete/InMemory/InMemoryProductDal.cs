using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product { ProductId = 2, CategoryId = 1, ProductName = "kalem", UnitPrice = 5, UnitsInStock = 2 },
            new  Product { ProductId = 1, CategoryId = 3, ProductName = "silgi", UnitPrice = 6, UnitsInStock = 43 },
            new Product { ProductId = 4, CategoryId = 9, ProductName = "mendil", UnitPrice = 7, UnitsInStock = 23 },
            new Product { ProductId = 5, CategoryId = 2, ProductName = "toka", UnitPrice = 8, UnitsInStock = 2211 },
            new Product { ProductId = 6, CategoryId = 6, ProductName = "krem", UnitPrice = 9, UnitsInStock = 1111 }
        };
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
