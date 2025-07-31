#include "armstrong_numbers.h"

bool is_armstrong_number(int candidate){
 if(candidate == 0) return true; 
 int sum = 0;
 int digits = log10(candidate) + 1;
 int copy = candidate;
 while(candidate > 0){
  int curr = candidate % 10;
  sum += pow(curr, digits);
  candidate /= 10;
 }
 return sum == copy;
}
