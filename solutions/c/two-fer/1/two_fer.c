#include "two_fer.h"

void two_fer(char *buffer, const char *name){
  *buffer = '\0';
  if(name==NULL){
    strcat(buffer, "One for you, one for me.");
  }
  else{
    strcat(buffer, "One for ");
    strcat(buffer, name);
    strcat(buffer, ", one for me.");
  }
}
