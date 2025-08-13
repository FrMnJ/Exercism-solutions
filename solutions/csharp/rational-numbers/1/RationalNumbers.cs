public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return Math.Pow(Math.Pow(realNumber, r.Numerator), 1.0 / r.Denominator);
    }

    public static int GCD(this RationalNumber r)
    {
        int a = Math.Abs(r.Numerator);
        int b = Math.Abs(r.Denominator);
    
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

public struct RationalNumber
{
    public int Numerator { get; private set; }
    public int Denominator {get; private set;}
    public RationalNumber(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
        if(denominator == 0) throw new ArgumentException(nameof(denominator), "Denominator can not be zero");
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        => new RationalNumber((r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator) , (r1.Denominator * r2.Denominator)).Reduce();
    

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        => new RationalNumber((r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator) , (r1.Denominator * r2.Denominator)).Reduce();

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        => new RationalNumber((r1.Numerator * r2.Numerator), (r1.Denominator * r2.Denominator)).Reduce();

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        => new RationalNumber((r1.Numerator * r2.Denominator), (r2.Numerator * r1.Denominator)).Reduce();

    public RationalNumber Abs()
        => new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator)).Reduce();

    public RationalNumber Reduce()
    {
        int gcd = this.GCD();
        int numerator = Numerator / gcd;
        int denominator = Denominator / gcd;
        if(denominator < 0) 
        {
            denominator *= -1;
            numerator *= -1;
        }
        
        return new RationalNumber(numerator, denominator);
    }

    public RationalNumber Exprational(int power)
    {
        if(power >= 0){
            return new RationalNumber(
                (int)Math.Pow(this.Numerator, power),
                (int)Math.Pow(this.Denominator, power)
            ).Reduce();
        }
        else{
                int m = Math.Abs(power);
                return new RationalNumber(
                (int)Math.Pow(this.Denominator, m),
                (int)Math.Pow(this.Numerator, m)
            ).Reduce();
        }
    }

    public double Expreal(int baseNumber)
        => baseNumber.Expreal(this);
    
}