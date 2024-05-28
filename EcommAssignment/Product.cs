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
        public float stock { get; set; }

        //Constructor
        public Product(int productId, String productName, float price, float stock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.stock = stock;
        }

        public void increaseStockPrice(float stock)
        {
            this.stock += stock;
        }

        public void decreaseStockPrice(float stock) 
        {  
            this.stock -= stock; 
        }
    }
}
