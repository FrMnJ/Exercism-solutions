#include "hamming.h"

int compute(const char *lhs, const char *rhs){
 if(strlen(lhs) != strlen(rhs)) return -1;
 int count = 0;
 for(;*lhs != '\0' || *rhs != '\0'; lhs++, rhs++){
  if(*lhs != *rhs) count++;
 }
 return count;
}
