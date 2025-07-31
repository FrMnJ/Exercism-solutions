#include "space_age.h"

float orbital_periods[] = { 
  0.2408467f * EARTH_SECONDS,
  0.61519726f * EARTH_SECONDS,
  1.0f * EARTH_SECONDS,
  1.8808158f * EARTH_SECONDS,
  11.862615f * EARTH_SECONDS,
  29.447498f * EARTH_SECONDS,
  84.016846f * EARTH_SECONDS,
  164.79132f * EARTH_SECONDS 
};

float age(planet_t planet, int64_t seconds){
  return planet<0||planet>NEPTUNE ? -1 : seconds / orbital_periods[(int)planet];
}

