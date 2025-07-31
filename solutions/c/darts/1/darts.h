#ifndef DARTS_H
#define DARTS_H
#include <stdint.h>
#include <math.h>

typedef struct Coordinate{
  float x;
  float y;
} coordinate_t;

uint8_t score(coordinate_t);
float calculate_distance_from_center(coordinate_t);
#endif
