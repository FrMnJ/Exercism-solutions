#include "perfect_numbers.h"

   /*PERFECT_NUMBER = 1,
   ABUNDANT_NUMBER = 2,
   DEFICIENT_NUMBER = 3,
   ERROR = -1*/

kind classify_number(int num){
  if(num<1) return ERROR;
  int aliquot = 0;
  for(int i = 1; i < num ; i++){
    if(num % i == 0) aliquot += i;
  }
  if(num==aliquot){
    return PERFECT_NUMBER;
  }
  else if(num<aliquot){
    return ABUNDANT_NUMBER;
  }
  else{
    return DEFICIENT_NUMBER;
  }
}
