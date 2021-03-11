using System;
using System.Collections.Generic;
using System.Text;

namespace System_Sales.Sales_System
{
    class Store
    {
        public Seller[] Sellers = new Seller[5];
        int sellerCount = 0;

        public Product[] Products = new Product[3];
        int productsCount = 0;

        public Sales[] Sales = new Sales[15];
        int salesCount = 0;

        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productsCount] = newProduct;
            productsCount++;
        }

        public void AddSales(Sales newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }

        //1. Who's the seller (sales man name), who has sold the cheapest product.
        public string SellerCheapest(Sales[] sales)
        {
            double priceCheapest = sales[0].Product.Price;
            string salesman = " ";
            
            for(int i = 0; i < salesCount; i++)
            {
                if (Sales[i].Product.Price <= priceCheapest)
                {
                    priceCheapest = sales[i].Product.Price;
                    salesman = Sales[i].Seller.Name;
                }
           
            }
            return salesman;
        }

        //2. Products price average
        public double priceAverage(Product[] products)
        {
            double pricesSum = 0;
            double average;

            for (int i = 0; i < productsCount; i++)
            {
                pricesSum = pricesSum + products[i].Price;
            }
            
            average = pricesSum / productsCount;
            return average;
        }

        //3. How many unit of the product has been sold.
        public double unitProductsSould()
        {
            double countUnitProducts = 0;
            for (int i = 0; i <= productsCount - 1; i++)
            {
                if (Products[i].Price != 0)
                {
                    countUnitProducts++;
                }
            }
            return countUnitProducts;
        }

        //4. What's the most expensive product.
        public Product mostExpensiveProduct(Product[] products)
        {
            Product mostProduct = products[0];
            for (int i = 0; i < productsCount; i++)
            {
                if (products[i].Price >= mostProduct.Price)
                {
                    mostProduct = products[i];
                }
            }

            return mostProduct;
        }
    }
}
