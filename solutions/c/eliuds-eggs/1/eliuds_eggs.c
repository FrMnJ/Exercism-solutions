#include "eliuds_eggs.h"

int egg_count(int coop){
  int count = 0;
  long power = 1;
  while(power<=coop){
    if(power & coop) count++;
    power <<= 1;
  }
  return count;
}
