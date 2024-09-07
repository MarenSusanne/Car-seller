using System.Xml.Linq;

namespace Car_seller;

public class WorkingCar
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public WorkingCar(int price, string name, string description)
    {
        Name = name;
        Description = description;
        Price = price;
    }

}