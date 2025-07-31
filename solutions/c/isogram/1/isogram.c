#include "isogram.h"

bool is_isogram(const char phrase[]){
  if(phrase == NULL) return false;
  if(!*phrase) return true;
  int32_t set = { 0 };
  for(; *phrase ; phrase++){
    if(!isalpha(*phrase)) continue;
    int c = tolower(*phrase) - 'a';
    if(set & (1 << c)){
      return false;
    }
    set |= (1 << c);
  }
  return true;
}
