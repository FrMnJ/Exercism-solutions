#include "resistor_color.h"

uint16_t color_code(resistor_band_t color){
  return (uint16_t)color;
}

resistor_band_t* colors(){
static resistor_band_t bands[] = {
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
  };
  return bands;
}
