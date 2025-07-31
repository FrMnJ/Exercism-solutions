#include "difference_of_squares.h"

namespace difference_of_squares {
    long long square_of_sum(long long n){
        return std::pow(((n*(n+1))/2),2);
    }
    
    long long sum_of_squares(long long n){
        return (n*(n+1)*(2*n+1))/6;
    }
    
    long long difference(long long n){
        return square_of_sum(n) - sum_of_squares(n);
    }
}  // namespace difference_of_squares
