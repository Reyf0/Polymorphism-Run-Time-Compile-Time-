using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market
{
    public abstract class Product
    {
        public string Name { get; set; }
        protected virtual double Price { get; set; }
        public virtual double PriceWithDiscount
        {
            get
            {
                // Discount is defined here, can be changed as needed
                return Price * (1 - 0.1); // 10% discount
            }
        }

        public abstract string GetInformation();
    }

    
    public class Toy : Product
    {
        public string Material { get; set; }

        public override string GetInformation()
        {
            return $"{Name}: (Toy); Material: {Material} - Price: {PriceWithDiscount}";
        }

        protected override double Price
        {
            get { return 50.0; }
        }
    }

    public class Meat : Product
    {
        public string Type { get; set; }

        public override string GetInformation()
        {
            return $"{Name}: (Meat); Type: {Type}; Price: {PriceWithDiscount}";
        }

        protected override double Price
        {
            get { return 25.0; }
        }
    }

    public class Drinks : Product
    {
        public double Volume { get; set; }

        public override string GetInformation()
        {
            return $"{Name}: (Drinks); Volume: {Volume}ml; Price: {PriceWithDiscount}";
        }

        protected override double Price
        {
            get { return 5.0; }
        }
    }

    public class Book : Product
    {
        private string _author;
        private int _numPages;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int NumPages
        {
            get { return _numPages; }
            set { _numPages = value; }
        }

        public override string GetInformation()
        {
            return $"{Name}: (Book); Author: {Author}; Pages: {NumPages}; Price: {PriceWithDiscount:C}";
        }

        protected override double Price
        {
            get { return 15.99; }
        }
    }

    public class ElectronicDevice : Product
    {
        private string _manufacturer;
        private string _model;

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public override string GetInformation()
        {
            return $"{Name}: (Electronic Device); Manufacturer: {Manufacturer}; Model: {Model}; Price: {PriceWithDiscount:C}";
        }

        protected override double Price
        {
            get { return 99.99; }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
            new Toy { Name = "Teddy Bear", Material = "Plush" },
            new Meat { Name = "Steak", Type = "Beef" },
            new Drinks { Name = "Coke", Volume = 500 }
            };

            foreach (var product in products)
            {
                Console.WriteLine(product.GetInformation());
            }
        }
    }

}
