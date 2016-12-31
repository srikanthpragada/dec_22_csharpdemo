using System;

namespace csharpdemo
{
    class Product   : IComparable<Product>
    {
        private string name;
        private int price;

        public Product (string name, int price)
        {
            this.name = name;
            this.price = price; 
        }

        public override string ToString()
        {
            return name + " - " + price;
        }

        public override bool Equals(object obj)
        {
            Product other = obj as Product;  // convert Object to Product
            return this.name == other.name;
        }

        //  0, > 0, < 0 
        public int CompareTo(Product other)
        {
            return this.price - other.price; 
        }
    }

    class TestProduct
    {
        public static void Main()
        {
            Product p1 = new Product("iPhone7", 60000);
            Product p2 = new Product("Google Pixel", 55000);
            Product p3 = new Product("iPhone7", 60000);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1 == p3);
            Console.WriteLine(p1.Equals(p3));

            Console.WriteLine(p1.CompareTo(p3));

        }
    }
}
