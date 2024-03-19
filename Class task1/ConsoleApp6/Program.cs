namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Mercedes", "CLS", 10000, 4);
            Motorcycle motorcycle = new Motorcycle("Kawasaki", "Ninja", 5000, 2);

            Console.WriteLine(car.ShowFullInfo());
            Console.WriteLine(motorcycle.ShowFullInfo());

        }
        public class Vehicle
        {
            public string Brand;
            public string Model;
            public double Mile;

            public Vehicle(string brand, string model, double mile)
            {
                if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model))
                {
                    throw new ArgumentException("Marka ve Model belirtilmelidir.");
                }

                Brand = brand;
                Model = model;
                Mile = mile;
            }
        }

        public class Car : Vehicle
        {
            public int DoorsNum;

            public Car(string brand, string model, double mile, int doorsNum)
                : base(brand, model, mile)
            {
                DoorsNum = doorsNum;
            }

            public string ShowFullInfo()
            {
                return $"Marka: {Brand}, Model: {Model}, Km: {Mile}, Qapi Sayısı: {DoorsNum}";
            }
        }

        public class Motorcycle : Vehicle
        {
            public int WheelNum;

            public Motorcycle(string brand, string model, double mile, int wheelNum)
                : base(brand, model, mile)
            {
                WheelNum = wheelNum;
            }

            public string ShowFullInfo()
            {
                return $"Marka: {Brand}, Model: {Model}, Km: {Mile}, Teker Sayısı: {WheelNum}";
            }
        }






    }
   
}
