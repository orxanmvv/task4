

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Sony", "bizden alin razi qalin", 5, 999.0, 16, 1000);
            notebook.ShowFullData();
            notebook.Sale();
        }
    }

    public class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

        public Product(string name, string description, int count, double price)
        {
            Name = name;
            Description = description;
            Count = count;
            Price = price;
            IsStock = count > 0;
        }

        public void Sale()
        {
            if (Count > 0)
            {
                Count--;
                IsStock = Count > 0;
                Console.WriteLine("satilib.");
            }
            else
            {
                Console.WriteLine("stokda yoxdur!");
            }
        }
    }

    public class Notebook : Product
    {
        public byte RAM;
        public int Storage;

        public Notebook(string name, string description, int count, double price, byte ram, int storage)
            : base(name, description, count, price)
        {
            RAM = ram;
            Storage = storage;
        }

        public string GetFullInfo()
        {
            return $"Name: {Name}, Description: {Description}, Count: {Count}, Price: {Price}, RAM: {RAM}, Storage: {Storage}";
        }

        public void ShowFullData()
        {
            if (IsStock)
            {
                Console.WriteLine(GetFullInfo());
            }
            else
            {
                Console.WriteLine("Məhsul yoxdur!");
            }
        }
    }
}

