#include "collatz_conjecture.h"

namespace collatz_conjecture {

int steps(int n){
    if(n <= 0) throw std::domain_error("zero or negative numbers are not in the domain");
    int number_steps = 0;
    while(n != 1){
        n = ((n % 2 == 0)? n/2 : 3*n+1);
        ++number_steps;
    }
    return number_steps;
}

}  // namespace collatz_conjecture
