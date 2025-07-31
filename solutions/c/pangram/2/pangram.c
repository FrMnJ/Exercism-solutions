#include "pangram.h"

bool is_pangram(const char *sentence){
  if(!sentence || *sentence == '\0') return false;
  int32_t set = 0;
  for(;*sentence; sentence++){
    if(!isalpha(*sentence)) continue;
    int idx = tolower(*sentence) - 'a';
    set |= (1<<idx);
  }
  return set == FULLSET;
}
