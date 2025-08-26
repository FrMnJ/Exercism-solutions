using System;
using System.Text;
public static class Raindrops
{
    public static string Convert(int number)
    {
        StringBuilder builder = new();
        if(number % 3 == 0){
            builder.Append("Pling");
        }
        if(number % 5 == 0){
            builder.Append("Plang");
        }
        if(number % 7 == 0){
            builder.Append("Plong");
        }
        string res = builder.ToString();
        if(res.Length == 0){
            return number.ToString();
        }
        return res;
    }
}