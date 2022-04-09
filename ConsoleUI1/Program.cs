using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesManager salesManager = new SalesManager();
            salesManager.DoSale();
        }
    }
}
