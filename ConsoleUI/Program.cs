using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--InMemoryProductDal Başlıyor--");
            ProductManager productManager1 = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager1.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--EfProductDal Başlıyor--");

            ProductManager productManager2 = new ProductManager(new EfProductDal());
            foreach (var product in productManager2.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
