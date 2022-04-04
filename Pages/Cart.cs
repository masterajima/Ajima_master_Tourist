using System;
using System.Linq;
using System.Collections.Generic;
namespace GroceryStore.GroceryStoreList{

    public class Cart{
        public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public decimal Price { get; set; }
    }
    
    public class CartProduct
    {
        public int Quantity { get; set; }
        public Product Product 
        { 
            get{
return this.Product;
        }
      set{
this.Product=this.Product;
      }
       }

        public decimal Total
        {
            get
            {
                return Product.Price * Quantity;
            }
        }
    }
    



        public List<CartProduct> Items { get; set; } = new List<CartProduct>();

        public Decimal Total
        {
            get
            {
                decimal total = (decimal)0.0;
                foreach (var item in Items)
                {
                    total += item.Total;
                }
                return total;
            }
        }
        public DateTime LastAccessed { get; set; }
        public int TimeToLiveInSeconds { get; set; } = 30; // default
    }    
    }
