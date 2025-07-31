public class RemoteControlCar
{
    private struct Speed
    {
        public decimal Amount { get; }
        public SpeedUnits SpeedUnits { get; }

        public Speed(decimal amount, SpeedUnits speedUnits)
        {
            Amount = amount;
            SpeedUnits = speedUnits;
        }

        public override string ToString()
        {
            string unitsString = "meters per second";
            if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
            {
                unitsString = "centimeters per second";
            }

            return Amount + " " + unitsString;
        }
    }
    private enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }
    public class TelemetryC
    {
        private readonly RemoteControlCar car;

        public TelemetryC(RemoteControlCar car)
        {
            this.car = car;
        }

        public void Calibrate()
        {

        }

        public bool SelfTest() => true;
        

        public void ShowSponsor(string sponsorName)
        {
            car.SetSponsor(sponsorName);
        }

        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
            {
                speedUnits = SpeedUnits.CentimetersPerSecond;
            }

            car.SetSpeed(new Speed(amount, speedUnits));
        }
    }

    public string CurrentSponsor { get; private set; } = string.Empty;

    private Speed currentSpeed;

    private readonly TelemetryC telemetry;

    public RemoteControlCar()
    {
        telemetry = new TelemetryC(this);
        currentSpeed = new Speed(0, SpeedUnits.MetersPerSecond);
    }

    public TelemetryC Telemetry => telemetry;

    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    private void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;

    }

    private void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }
}
