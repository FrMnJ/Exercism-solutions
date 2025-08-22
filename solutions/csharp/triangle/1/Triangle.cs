public static class Triangle
{
    private static bool Validate(double side1, double side2, double side3){
        if(side1 <= 0 || side2 <= 0 || side3 <= 0 
          || (side1 + side2 < side3)
          || (side2 + side3 < side1)
          || (side1 + side3 < side2)) return false;
        else
            return true;
    }
    
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if(!Validate(side1, side2, side3)) return false;
        return side1 != side2 && side2 != side3 && side1 != side3;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if(!Validate(side1, side2, side3)) return false;
        return side1 == side2 || 
            side2 == side3 ||
            side1 == side3;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if(!Validate(side1, side2, side3)) return false;
        return side1 == side2 && 
            side2 == side3;
    }
}