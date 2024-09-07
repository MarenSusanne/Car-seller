namespace Car_seller;

public class Customer
{
    public List<WorkingCar> WorkingCars;
    public List<BrokenCar> BrokenCars;

    public Customer()
    {
        WorkingCars = new List<WorkingCar>
        {
            new WorkingCar(1000, "Luxury Sedan", "black, sleek one, with chrome accents and leather interior."),
            new WorkingCar(2000, "Hybrid Convertible", "silver one, polished, with a retractable hardtop."),
            new WorkingCar(3000, "Compact SUV", "white, shiny one, with advanced safety features."),
            new WorkingCar(4000, "Electric Hatchback", "blue, modern one, with a panoramic sunroof."),
            new WorkingCar(5000, "Off-Road Pickup", "green, rugged one, with alloy wheels and LED lights."),
            new WorkingCar(3000, "Family Minivan", "red, spacious one, with sliding doors and a rear entertainment system."),
            new WorkingCar(2000, "Sport Coupe", "yellow, aerodynamic one, with a high-performance engine."),
            new WorkingCar(1000, "Crossover", "gray, versatile one, with a digital dashboard and adaptive cruise control."),
            new WorkingCar(6000, "Luxury Electric Car", "pearl white, futuristic one, with a high-tech interior."),
            new WorkingCar(10000, "High-Performance Sports Car", "metallic silver, ultra-fast one, with carbon fiber trim."),
        };
        BrokenCars = new List<BrokenCar>
        {
            new BrokenCar("Sedan", "blue, slightly rusted"),
            new BrokenCar("Convertible", "silver, vintage"),
            new BrokenCar("SUV", "black, new"),
            new BrokenCar("Hatchback", "green, compact"),
            new BrokenCar("Pickup Truck", "white, rugged"),
            new BrokenCar("Minivan", "gray, spacious"),
            new BrokenCar("Coupe", "red, sporty"),
            new BrokenCar("Station Wagon", "brown, family car"),
            new BrokenCar("Electric Car", "white, modern"),
            new BrokenCar("Sports Car", "yellow, fast"),
        };
    }
    public Object ChooseCar(int rnd, int rndOption)
    {
        Object ChosenCar;
        if (rnd == 1)
        {
            ChosenCar = WorkingCars[rndOption];
        }
        else
        {
            ChosenCar = BrokenCars[rndOption];
        }


        return ChosenCar;
    }
    //public string ChooseCar(int rnd, int rndOption)
    //{
    //    string ChosenCarName;
    //    string ChosenCarDescription;
    //    if (rnd == 1)
    //    {
    //        ChosenCarName = WorkingCars[rndOption].Name;
    //        ChosenCarDescription = WorkingCars[rndOption].Description;
    //        Console.WriteLine("The customer wants to buy the " + ChosenCarName);
    //        Console.WriteLine("Good choice! That's the " + ChosenCarDescription);
    //    }
    //    else
    //    {
    //        ChosenCarName = BrokenCars[rndOption].Name;
    //        ChosenCarDescription = BrokenCars[rndOption].Description;
    //        Console.WriteLine("This customer has a broken " + ChosenCarName);
    //        Console.WriteLine("The " + ChosenCarDescription + " " + ChosenCarName + " has been sent to the workshop.");
    //    }


    //    return ChosenCarName;
    //}

}