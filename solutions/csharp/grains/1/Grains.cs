public static class Grains
{
    public static ulong Square(int n)
        => n < 1 || n > 64 ?
        throw new ArgumentOutOfRangeException() 
        : (ulong)1 << (n-1);
    

    public static ulong Total()
    {
        ulong res = 0;
        for(int i = 1; i <= 64; i++){
            res += Square(i);
        }
        return res;
    }
}