using System;
namespace ajimaGroceryStoreApp.Pages{
    public class CartProduct{
         public int Quantity { get; set; }
        public Product Product { get; set; }

        public decimal Total
        {
            get
            {
                return Product.Price * Quantity;
            }
        }
    }
    }
