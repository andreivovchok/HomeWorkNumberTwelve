using System;
using HomeWorkNumberTwelve;

namespace ConsoleAppProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product0 = new Product { ProductName = "Tshirt", StoreName = "Hugo" };
            Product product1 = new Product { ProductName = "Sneakers", StoreName = "Hugo" };
            Product product2 = new Product { ProductName = "Shirt", StoreName = "Hugo" };
            Product product3 = new Product { ProductName = "Jeans", StoreName = "Polo" };
            Product product4 = new Product { ProductName = "Shoes", StoreName = "Wrangler" };
            Product product5 = new Product { ProductName = "Jacket", StoreName = "Polo" };

            Product[] products = new Product[] { product3, product1, product2, product0, product4, product5 };

            Array.Sort(products, Product.CompareByStoreName);

            foreach (var product in products)
            {
                Console.WriteLine(product.StoreName);
            }

            Console.WriteLine("Введите название магазина!");
            string storeName = Console.ReadLine();
            bool storeExist = false;

            foreach (var product in products)
            {
                if (storeName == product.StoreName)
                {
                    Console.WriteLine(product.ProductName);
                    storeExist = true;
                }              
            }

            if (!storeExist)
            {
                throw new StoreNotFoundException(storeName);
            }
        }
    }
}
