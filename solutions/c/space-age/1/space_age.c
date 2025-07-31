#include "space_age.h"

float age(planet_t planet, int64_t seconds){
  const int year_in_seconds_earth = 31557600;
  float result = 0.0;
  float year_in_seconds = 0.0;
  switch(planet){
    case MERCURY:
      year_in_seconds = 0.2408467 * year_in_seconds_earth;
      result = (float)seconds / year_in_seconds;
      break;
    case VENUS:
      year_in_seconds = 0.61519726 * year_in_seconds_earth;
      result = (float)seconds / year_in_seconds;
      break;
    case MARS:
      year_in_seconds = 1.8808158 * year_in_seconds_earth;
      result = (float)seconds / year_in_seconds;
      break;
    case JUPITER:
      year_in_seconds = 11.862615 * year_in_seconds_earth;
      result = (float)seconds / year_in_seconds;
      break;
    case SATURN:
      year_in_seconds = 29.447498 * year_in_seconds_earth;
      result = (float)seconds / year_in_seconds;
      break;
    case URANUS:
      year_in_seconds = 84.016846 * year_in_seconds_earth;
      result = (float)seconds / year_in_seconds;
      break;
    case NEPTUNE: 
      year_in_seconds = 164.79132 * year_in_seconds_earth;
      result = (float)seconds / year_in_seconds;
      break;
    case EARTH:
      result = (float)seconds / year_in_seconds_earth;
      break;
    default:
      return -1.0;
  }
  return result;
}

