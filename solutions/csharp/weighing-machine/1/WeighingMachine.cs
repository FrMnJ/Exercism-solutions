class WeighingMachine
{
    // TODO: define the 'Precision' property
    private int precision;
    public int Precision { get => precision; }
    // TODO: define the 'Weight' property
    private double weight;
    public double Weight 
    {
        get => weight;
        set
        {
            if(value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Weight can not be negative");
            }
            weight = value;
        }
    }
    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get
        {
            double result = checked(Weight - TareAdjustment);
            return double.IsInfinity(result) ? "Error" : string.Format("{0:F" + Precision + "} kg", result);
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5f;

    public WeighingMachine(int precision)
    {
        this.precision = precision;
    }
}
