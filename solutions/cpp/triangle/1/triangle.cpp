#include "triangle.h"

namespace triangle {
    flavor kind(double a, double b, double c){
        if(!(a+b>=c and b+c>=a and a+c>=b) or a==0 or b==0 or c==0) throw std::domain_error("invalid triangle");
        if(a==b and b==c) return flavor::equilateral;
        else if(a==b || a==c || b==c) return flavor::isosceles;
        else return flavor::scalene;
    }
}  // namespace triangle
