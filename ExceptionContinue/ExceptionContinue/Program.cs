using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionContinue
{
    class Product
    {
        private int _quantity;
        private float _price;
        private double _sales;
        private string _productName;

        public Product()
        {
            _productName = "Motherboard";
        }

        public void AcceptDetails()
        {
            Console.Write("Enter product quantity : ");
            try
            {
                _quantity = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error : {0}",ex.Message);
            }

            Console.Write("Enter the price : ");
            if (float.TryParse(Console.ReadLine(), out _price))
            {
                _sales = _price * _quantity;
            }
            else
                Console.WriteLine("Invalid price inserted");         
        }
        public void Display()
        {
            Console.WriteLine("Product Name : {0}",_productName);
            Console.WriteLine("Product Quantity : {0}",_quantity);
            Console.WriteLine("Product Price : {0}",_price);
            Console.WriteLine("Product Sale : {0}",_sales);
        }
        public static void ProductTest()
        {
            var obj = new Product();
            obj.AcceptDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
