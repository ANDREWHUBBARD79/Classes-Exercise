namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();   //Constructor special number method new member of car class
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;


            var mazda = new Car()
            { Make = "Mazda",  Model = "Cx-5", Year = 2016 };


            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { myCar , mazda, chevy};
            Console.WriteLine(carList.Capacity);

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
