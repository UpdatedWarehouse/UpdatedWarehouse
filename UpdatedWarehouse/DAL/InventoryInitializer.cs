using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using UpdatedWarehouse.Models;


namespace UpdatedWarehouse.DAL
{
    public class InventoryInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<InventoryContext> //Causes DB to be created
    {
        protected override void Seed(InventoryContext context)
        {
            var products = new List<Product>
            {
                new Product {ProductName = "Calculator", Price = 10.00, Quantity = 5},
                new Product {ProductName = "Pencil Box", Price = 5.00, Quantity = 3},
                new Product {ProductName = "Pen Box", Price = 5.00, Quantity = 2},
                new Product {ProductName = "Keyboard", Price = 100.00, Quantity = 7},
                new Product {ProductName = "Printer", Price = 150.00, Quantity = 5}, 
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
            var categories = new List<Category>
            {
                new Category{CategoryId = 1, Type = "Office"},
                new Category{CategoryId = 2, Type = "Computer"},
            
            };
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();
        }
    }
}