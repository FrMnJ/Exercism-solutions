#ifndef TRIANGLE_H
#define TRIANGLE_H
#include <assert.h>
#include <stdbool.h>


typedef struct {
   double a;
   double b;
   double c;
} triangle_t;

bool is_valid_triangle(const triangle_t*);
bool is_equilateral(const triangle_t);
bool is_isosceles(const triangle_t);
bool is_scalene(const triangle_t);
#endif
