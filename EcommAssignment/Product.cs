using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommAssignment
{
    public class Product
    {
        public int productId { get; set; }
        public String productName { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }

        //Constructor
        public Product(int productID, string productName, decimal price, int stock)
        {
            if (productID < 1 || productID > 5000)
                throw new ArgumentOutOfRangeException(nameof(productID), "ProductID must be between 1 and 5000.");
            if (price < 1 || price > 10000)
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be between 1 and 10000.");
            if (stock < 1 || stock > 5000)
                throw new ArgumentOutOfRangeException(nameof(stock), "Stock must be between 1 and 5000.");

            this.productId = productID;
            this.productName = productName ?? throw new ArgumentNullException(nameof(productName));
            this.price = price;
            this.stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Increase amount must be greater than zero.");

            stock += amount;
        }

        public void DecreaseStock(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Decrease amount must be greater than zero.");
            if (amount > stock)
                throw new InvalidOperationException("Cannot decrease stock below zero.");

            stock -= amount;
        }
    }
}
