#include "darts.h"

float calculate_distance_from_center(coordinate_t coor){
  return sqrt(coor.x * coor.x + coor.y * coor.y);
}

uint8_t score(coordinate_t coor){
  float distance = calculate_distance_from_center(coor);
  if(distance > 10) return 0;
  else if(distance > 5) return 1;
  else if(distance > 1) return 5;
  return 10;
}
