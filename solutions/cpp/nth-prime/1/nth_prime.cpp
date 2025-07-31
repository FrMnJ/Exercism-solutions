#include "nth_prime.h"

namespace nth_prime {

    long long nth(size_t n){
        if(n <= 0) throw std::domain_error("n must be greater or equal to 1");
        std::bitset<MAX_SIZE> bit_mask;
        std::vector<long long> primes;
        long long i = 2;
        while(primes.size() < n){
            if(! bit_mask[i]){
                primes.emplace_back(i);
                for(size_t j = i*i;j < bit_mask.size();j += i){
                    bit_mask[j] = 1;
                }
            }
            ++i;
        }
        return primes[n - 1];
    }

}  // namespace nth_prime
