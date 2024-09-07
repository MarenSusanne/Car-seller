using System.Xml.Linq;

namespace Car_seller;

public class BrokenCar
{
    public string Name { get; set; }
    public string Description { get; set; }
    private List<CarPart> _parts;
    public string BrokenPart;

    public BrokenCar(string name, string description)
    {
        Name = name;
        Description = description;
        _parts = new List<CarPart>()
        {
            new ("Wheel"),
            new("Tires"),
            new("Engine"),
            new("Windshield"),
            new("Lights"),
        };
    }
}