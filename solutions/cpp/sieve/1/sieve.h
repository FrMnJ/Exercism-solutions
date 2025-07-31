#if !defined(SIEVE_H)
#define SIEVE_H
#include <vector>
#include <bitset>
#define MAX 1'000'000
namespace sieve {

std::vector<int> primes(int upper_limit);

}  // namespace sieve

#endif  // SIEVE_H