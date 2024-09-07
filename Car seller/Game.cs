using System.ComponentModel.DataAnnotations;

namespace Car_seller;

public class Game
{
    Store _store = new();
    Workshop _workshop =new();
    Customer _customer = new();

    public Game()
    {
        Console.WriteLine("A new customer is entering the store!");
        var ChosenCar = _customer.ChooseCar(Random(1,2), Random(0,9));
        if ()
        {
            Console.WriteLine("The customer wants to buy the " + ChosenCar);
            Console.WriteLine("Good choice! That's the " + ChosenCar);
        }
        else
        {
            Console.WriteLine("This customer has a broken " + ChosenCar);
            Console.WriteLine("The " + ChosenCar + " " + ChosenCar + " has been sent to the workshop.");
        }

    }

    public int Random(int Min, int Max)
    {
        Random rnd = new Random();
        int random = rnd.Next(Min, Max +1);
        return random;
    }
}