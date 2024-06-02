using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommAssignment;

internal class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Product Details - ");

        Console.Write("Enter the ProductId : ");
        var productId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Product Name : ");
        var productName = Console.ReadLine();

        Console.Write("Enter the Product Price : ");
        var price = float.Parse(Console.ReadLine());

        Console.Write("Enter the Stock quantity : ");
        var stock = Convert.ToInt32(Console.ReadLine());

        Product product = new Product(productId,productName,price,stock);

        Console.Write("\n\nEnter 1 to increase stock qunatity or 2 to decrease the stock quantity : ");
        var choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("\n\nEnter the stock value : ");
        var stockChange = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                product.increaseStockPrice(stockChange);
                break;
            case 2:
                product.decreaseStockPrice(stockChange);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        Console.WriteLine($"\n\nProduct Id : {product.productId}\nProduct Name : {product.productName}\nProduct Price : {product.price}\nProduct stock quantity : {product.stock}");
    }
}