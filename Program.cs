using System;
using System_Sales.Sales_System;

namespace System_Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object: Store
            Store stores = new Store();

            //Object: Seller
            Seller s1 = new Seller();
            s1.Name = "Juan";
            s1.Age = 20;
            stores.AddSeller(s1);

            Seller s2 = new Seller();
            s2.Name = "Lucia";
            s2.Age = 25;
            stores.AddSeller(s2);

            Seller s3 = new Seller();
            s3.Name = "Pablo";
            s3.Age = 17;
            stores.AddSeller(s3);

            //Object: Product
            Product p1 = new Product();
            p1.Code = 1;
            p1.Name = "Carrot";
            p1.Price = 2000f;
            stores.AddProduct(p1);

            Product p2 = new Product();
            p2.Code = 2;
            p2.Name = "Banana";
            p2.Price = 1000f;
            stores.AddProduct(p2);

            Product p3 = new Product();
            p3.Code = 3;
            p3.Name = "Apple";
            p3.Price = 2000f;
            stores.AddProduct(p3);

            //Object: Sale
            Sales sa1 = new Sales();
            sa1.Seller = s1;
            sa1.Product = p3;
            sa1.SetComments(1);
            stores.AddSales(sa1);

            Sales sa2 = new Sales();
            sa2.Seller = s2;
            sa2.Product = p2;
            sa2.SetComments(0);
            stores.AddSales(sa2);

            Sales sa3 = new Sales();
            sa3.Seller = s3;
            sa3.Product = p1;
            sa3.SetComments(0);
            stores.AddSales(sa3);


            //Calculate sales total amount
            float sum;

            double sumTotal = (sa1.Product.Price + sa2.Product.Price + sa3.Product.Price);
            System.Console.WriteLine("The total amount of sales is: " + sumTotal);


           String cheapestSeller = stores.SellerCheapest(stores.Sales);
            System.Console.WriteLine("The seller who sold the cheapest product was: " + cheapestSeller);

            double average = stores.priceAverage(stores.Products);
            System.Console.WriteLine("The average price of the products is: " + average);

            double unit = stores.unitProductsSould();
            System.Console.WriteLine("Of this product in units have been sold " + unit);

            Product mostExpensiveProduct = stores.mostExpensiveProduct(stores.Products);
            System.Console.WriteLine("The most expensive product is: " + mostExpensiveProduct.Name + " priced at: " +mostExpensiveProduct.Price);
            

        }
    }
}
