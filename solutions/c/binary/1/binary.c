#include "binary.h"

int convert(const char *input){
  int len_bin = strlen(input);
  int max_power = 1<<(len_bin-1);
  int res = 0;
  while(*input != '\0'){
    if(*input!='1'&&*input!='0') return INVALID;
    res += max_power * (*input-'0');
    max_power >>= 1;  
    input++;
  }
  return res;
}
