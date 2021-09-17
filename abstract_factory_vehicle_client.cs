using System;

interface VehicleFactory
{
    Bike GetBike(string Bike);
    Scooter GetScooter(string Bike);
}
class HondaFactory : VehicleFactory
{
    public Bike GetBike(string Bike)
    {
        switch (Bike)
        {
            case "Sports":
                return new SportsBike();
            case "Regular":
                return new RegularBike();
            default:
                throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created",Bike));
        }

    }
    public Scooter GetScooter(string Bike)
    {
        switch (Bike)
        {
            case "Sports":
                return new Scooty();
            case "Regular":
                return new RegularSccoter();
            default:
                throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
        }
    }
}
class HeroFactory :VehicleFactory
{
    public Bike GetBike(string Bike)
    {
        switch (Bike)
        {
            case "Sports":
                return new SportsBike();
            case "Regular":
                return new RegularBike();
            default:
                throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
        }

    }
    public Scooter GetScooter(string Bike)
    {
        switch (Bike)
        {
            case "Sports":
                return new Scooty();
            case "Regular":
                return new RegularSccoter();
            default:
                throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
        }
    }
}

class VehicleClient
{
    Bike bike;
    Scooter scooter;

    public VehicleClient(VehicleFactory factory, string type)
    {
        bike = factory.GetBike(type);
        scooter = factory.GetScooter(type);
    }
    public string GetBikeName()
    {
        return bike.name();
    }
    public string GetScooterName()
    {
        return scooter.name();
    }
}
interface Bike
{
    string name();
}
interface Scooter
{
    string name();
}
class RegularBike : Bike
{
    public string name()
    {
        return "Ninja 400 is a cool bike";
    }
}
class SportsBike : Bike
{
    public string name()
    {
        return "Hayabosa is sports bike";
    }
}
class Scooty: Scooter
{
    public string name()
    {
        return "activa is most sold scooty in india.";
    }
    
}
class RegularSccoter : Scooter
{
    public string name()
    {
        return " regular scooter ";
    }
}
class Program
{
    public static void Main()
    {
        VehicleFactory honda = new HondaFactory();
        VehicleClient hondaclient = new VehicleClient(honda, "Regular");

        Console.WriteLine("******* Honda **********");
        Console.WriteLine(hondaclient.GetBikeName());
        Console.WriteLine(hondaclient.GetScooterName());

        hondaclient = new VehicleClient(honda, "Sports");
        Console.WriteLine(hondaclient.GetBikeName());
        Console.WriteLine(hondaclient.GetScooterName());

        VehicleFactory hero = new HeroFactory();
        VehicleClient heroclient = new VehicleClient(hero, "Regular");

        Console.WriteLine("******* Hero **********");
        Console.WriteLine(heroclient.GetBikeName());
        Console.WriteLine(heroclient.GetScooterName());

        heroclient = new VehicleClient(hero, "Sports");
        Console.WriteLine(heroclient.GetBikeName());
        Console.WriteLine(heroclient.GetScooterName());

        Console.ReadKey();

    }
 
}
