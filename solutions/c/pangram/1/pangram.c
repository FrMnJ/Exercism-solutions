#include "pangram.h"

bool is_pangram(const char *sentence){
  if(!sentence || *sentence == '\0') return false;
  bool marks[26] = { 0 };
  short count = 0;
  while(*sentence){
    int idx = 0;
    if(*sentence >= 'A' && *sentence <= 'Z') 
      idx =  *sentence - 'A';
    else if(*sentence >= 'a' && *sentence <= 'z') 
      idx = *sentence - 'a';
    else {
      sentence++;
      continue;
    }
    if(!marks[idx]){
      count++;
      marks[idx] = true;
    }
    sentence++;
  }
  return count == 26;
}
