public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int sum = 0;
        string numberStr = number.ToString();
        foreach(char d in numberStr){
            sum += (int)Math.Pow(int.Parse(""+d), numberStr.Length);
        }
        return sum == number;
    }
}