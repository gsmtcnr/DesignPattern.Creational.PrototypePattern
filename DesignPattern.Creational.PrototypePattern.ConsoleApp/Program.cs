using DesignPattern.Creational.PrototypePattern.Model;
using System;

namespace DesignPattern.Creational.PrototypePattern.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string contactName = "Samet Çınar";
            string address = "sametcinar.com";
            decimal totalPrice = 125M;

            var mainOrder = Order.Create(contactName, address, totalPrice);
            OrderInformation(mainOrder);

            var cloneOrder = mainOrder.Repeat();
            OrderInformation(cloneOrder);

            var cloneOrder1 = mainOrder.Repeat();
            OrderInformation(cloneOrder1);

            var cloneOrder2 = mainOrder.Repeat();
            OrderInformation(cloneOrder1);

            Console.ReadLine();
        }
        private static void OrderInformation(Order order)
        {
            Console.WriteLine("---");

            Console.WriteLine("Id: " + order.Id);
            Console.WriteLine("Contact: " + order.Contact);
            Console.WriteLine("Address: " + order.Address);

            Console.WriteLine("---");

        }
    }
}
