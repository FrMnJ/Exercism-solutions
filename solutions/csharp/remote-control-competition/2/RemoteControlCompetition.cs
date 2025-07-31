// TODO implement the IRemoteControlCar interface
public interface IRemoteControlCar
{
    void Drive();
    int DistanceTravelled { get; }
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public int CompareTo(ProductionRemoteControlCar? other)
    {
        if(other == null) return 1;
        if(NumberOfVictories > other.NumberOfVictories) return 1;
        else if(NumberOfVictories < other.NumberOfVictories) return -1;
        else return 0;
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        List<ProductionRemoteControlCar> cars = new();
        if(prc1.CompareTo(prc2) < 0)
        {
            cars.Add(prc1);
            cars.Add(prc2);
        }
        else
        {
            cars.Add(prc2);
            cars.Add(prc1);
        }
        return cars;
    }
}
