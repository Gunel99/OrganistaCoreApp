using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Models
{
    public class Cart
    {
        private List<CartLine> products = new List<CartLine>();
        public List<CartLine> Products => products;

        public void AddProduct(Product product, int quantity)
        {
            var prd = products
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();

            if (prd == null)
            {
                products.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                prd.Quantity += quantity;
            }
        }
        
        public void RemoveProduct(Product product)
        {
            products.RemoveAll(p => p.Product.Id == product.Id);
        }
        
        public double TotalPrice()
        {
            return products.Sum(p => p.Product.Price * p.Quantity);
        }

        public void ClearAll()
        {
            products.Clear();
        }
    }

    public class CartLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
 
    }
}
