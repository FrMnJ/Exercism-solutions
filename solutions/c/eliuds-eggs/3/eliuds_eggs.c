#include "eliuds_eggs.h"

int egg_count(int coop){
  int count = 0;
  while(coop){
    count++;
    coop &= coop - 1;
  }
  return count;
}
