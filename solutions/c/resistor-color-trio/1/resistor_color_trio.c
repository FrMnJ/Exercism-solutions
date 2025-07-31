#include "resistor_color_trio.h"

resistor_value_t color_code(resistor_band_t* bands){
  resistor_value_t res = {
    .value = 0,
    .unit = OHMS
  };
  long value = bands[0] * 10 + bands[1];
  long unit = 1;
  for(int i = 0; i < (int)bands[2]; i++) unit *= 10;
  value *= unit;
  if(value < 1000) {
    res.unit = OHMS;
    res.value = value;
  }
  else if(value < 1000000) {
    res.unit = KILOOHMS;
    res.value = value / 1000;
  }
  else if(value < 1000000000){
    res.unit = MEGAOHMS;
    res.value = value / 1000000;
  }
  else if(value < 1000000000000){
    res.unit = GIGAOHMS;
    res.value = value / 1000000000;
  }
  return res;
}
