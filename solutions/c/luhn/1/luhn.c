#include "luhn.h"

bool luhn(const char *num){
 int len = strlen(num); 
 int j = 0;
 int sum = 0;
 for(int i = len - 1; i >= 0; i--){
  if(isdigit(num[i])){
     int d = num[i] - '0'; 
     if(j % 2 == 1){
      d *= 2;
      d = d > 9 ? d - 9 : d;
     }
     sum += d;
     j++;
  }
  else if(isspace(num[i])) continue;
  else return false;
 }
 if(j < 2) return false;
 return sum % 10 == 0;
}
