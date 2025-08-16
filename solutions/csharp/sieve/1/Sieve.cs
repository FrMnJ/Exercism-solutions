public static class Sieve
{
    public static int[] Primes(int limit)
    {
        bool[] sieve = new bool[limit + 1];
        List<int> primes = new();
        for(int i = 2; i <= limit; i++){
            if(!sieve[i]){
                primes.Add(i);
                for(int j = i + i; j <= limit; j+=i){
                    sieve[j] = true;
                }
            }
        }
        return primes.ToArray();
    }
}