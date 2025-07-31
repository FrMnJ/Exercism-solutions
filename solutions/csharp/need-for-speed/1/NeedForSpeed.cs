class RemoteControlCar
{
    private readonly int speed;
    private readonly int batteryDrain;
    private int batteryLevel = 100;
    private int distance = 0;

    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => batteryLevel <= batteryDrain;

    public int DistanceDriven() => distance;

    public void Drive()
    {
        if (batteryLevel < batteryDrain) return;
        batteryLevel -= batteryDrain;
        distance += speed;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private readonly int distance;

    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && car.DistanceDriven() < distance)
        {
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}
