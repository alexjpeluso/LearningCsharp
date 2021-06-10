using System;

namespace Exercise10
{
    class Product
    {
        private string name;
        private double price;
        private int quantity;

        public Product ()
        {
            Console.Write("Enter product name: ");
            string nameUser = Console.ReadLine();
            this.name = nameUser;

            Console.Write("Enter product price: ");
            double priceUser = Convert.ToDouble(Console.ReadLine());
            this.price = priceUser;

            Console.Write("Enter product quantity: ");
            int quantityUser = Convert.ToInt32(Console.ReadLine());
            this.quantity = quantityUser;

            Console.WriteLine();
        }

        public double totalValue()
        {
            return price * quantity;
        }
        
        public string displayInfo()
        {
            String message = $"Product Name: {this.name} \n";
            message += $"Price: ${this.price} \n";
            message += $"Quantity: {this.quantity} \n";
            message += $"totalvalue: ${totalValue()} \n";

            return message;
        }
    }
}
