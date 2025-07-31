#include "resistor_color_duo.h"

/*typedef enum {
  BLACK,
  BROWN,
  RED,
  ORANGE,
  YELLOW,
  GREEN,
  BLUE,
  VIOLET,
  GREY,
  WHITE
} resistor_band_t;*/

uint16_t color_code(resistor_band_t bands[]){
  int res = (int)bands[0] * 10;
  res += (int)bands[1];
  return res;
}
