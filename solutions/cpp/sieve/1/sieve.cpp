#include "sieve.h"

namespace sieve {

    std::vector<int> primes(int upper_limit){
        std::bitset<MAX> prime_mask;
        std::vector<int> primes;
        for(int i = 2; i <= upper_limit; ++i){
            if(!prime_mask[i]){
                primes.push_back(i);
                for(int j = i * i; j <= upper_limit ; j += i){
                    prime_mask[j] = true;
                }
            }
        }
        return primes;
    }

}  // namespace sieve
