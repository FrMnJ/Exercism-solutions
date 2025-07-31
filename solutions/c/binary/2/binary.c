#include "binary.h"

int convert(const char *input){
  int max_power = 1<<(strlen(input)-1);
  int res = 0;
  while(*input){
    if(*input != '1'&&*input != '0') return INVALID;
    res += max_power * (*input-'0');
    max_power >>= 1;  
    input++;
  }
  return res;
}
