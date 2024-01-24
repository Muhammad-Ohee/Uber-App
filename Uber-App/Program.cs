//Console.WriteLine("Hello, OS");

namespace UberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IBluePrint vehicle1 = new Bike(12);
            //vehicle1.Display();
            //vehicle1.Print();

            Bike vehicle2 = new Bike(12);
            //vehicle2.Display();

            RentAbs vehicle = new Bike(13);
            vehicle = new Car(34);
            //vehicle.tavel_dis();

            //vehicle.Display();


            Bike displayBike = new Bike();
            Console.Write("How much distance you have travelled with bike: ");
            decimal travelDistanceWithBike = Convert.ToDecimal(Console.ReadLine()); ;
            Bike bikeWithTravel = new Bike(travelDistanceWithBike);
            decimal bikeRentWithTravel = bikeWithTravel.tavel_dis();
            Console.WriteLine($"Total Cost: {bikeRentWithTravel} BDT");

            Console.WriteLine("");
            //Console.WriteLine("====================");
            Console.WriteLine("");

            Car displayCar = new Car();
            Console.Write("How much distance you have travelled with car: ");
            decimal travelDistanceWithCar = Convert.ToDecimal(Console.ReadLine()); ;
            Car carWithTravel = new Car(travelDistanceWithCar);
            decimal carRentWithTravel = carWithTravel.tavel_dis();
            Console.WriteLine($"Travel with car: {carRentWithTravel} taka");







            //Bike bike_without_travel = new Bike(100);
            //decimal bike_rent_without_travel = bike_without_travel.bikerent();
            //bike_without_travel.Print();
            //Console.WriteLine($"Without Travel with bike: {bike_rent_without_travel} taka");

            //Car car_without_travel = new Car(100);
            //decimal car_rent_without_travel = car_without_travel.carrent();
            //car_without_travel.Print();
            //Console.WriteLine($"Without Travel with car: {car_rent_without_travel} taka");

        }
    }

    /*
    class Uber
    {
        private string car;
        private double car_rent;

        private string bike;
        private double bike_rent;




        public void setCarRent(string car, double car_rent) 
        {
            this.car = car;
            this.car_rent = car_rent;
        }

        public string getCar() 
        { 
            return this.car + " " + Convert.ToString(this.car_rent + (this.car_rent * 0.4)); 
        }

        public void setBikeRent(string bike, double bike_rent)
        {
            this.bike = bike;
            this.bike_rent = bike_rent;
        }

        public string getBike()
        {
            return this.bike + " " + Convert.ToString(this.bike_rent + (this.bike_rent * 0.2));
        }
    }
    */
}