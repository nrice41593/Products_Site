﻿using System;
using System.Collections.Generic;
using ProductDisplayProject.Models;
namespace ProductDisplayProject
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);
    }
}
