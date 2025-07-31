#include "grains.h"

uint64_t square(uint8_t index){
  if(index == 0) return 0;
  uint64_t res = 1;
  for(uint8_t i = 0; i < index - 1; i++){
    res = res << 1;
  }
  return res;
}

uint64_t total(void){
  uint64_t sum = 0;
  for(uint8_t i = 1; i <= 64; i++){
    sum += square(i);
  }
  return sum;
}
