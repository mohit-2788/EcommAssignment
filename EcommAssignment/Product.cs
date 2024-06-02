using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommAssignment
{
    public class Product
    {
        public int productId { get; set; }
        public String productName { get; set; }
        public float price { get; set; }
        public int stock { get; set; }

        //Constructor
        public Product(int productId, String productName, float price, int stock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.stock = stock;
        }

        public void increaseStockPrice(int stock)
        {
            this.stock += stock;
        }

        public void decreaseStockPrice(int stock) 
        {  
            this.stock -= stock; 
        }
    }
}
