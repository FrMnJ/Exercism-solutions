class RemoteControlCar
{
    public int battery  = 100;
    public int distance = 0;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {distance} meters";

    public string BatteryDisplay() => battery switch
    {
        0 => "Battery empty",
        _ => $"Battery at {battery}%"
    };

    public void Drive()
    {
        if(!IsBatteryEmpty)
        {
            distance += 20;
            battery -= 1;
        }
    }
    private bool IsBatteryEmpty => battery == 0;
}
