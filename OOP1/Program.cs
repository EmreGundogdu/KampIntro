using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Id = 1;
            product.productName = "Masa";
            product.categoryId = 2;
            product.unitPrice = 500;
            product.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, categoryId = 5, UnitsInStock = 5, productName = "Kalem", unitPrice = 35 };

            //Pascal case  //camel case
            ProductManager productManager = new ProductManager();
            productManager.Add(product);
        }
        
    }

}