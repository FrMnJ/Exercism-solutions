#include "triangle.h"

bool is_valid_triangle(const triangle_t *t){
  if(!(t->a > 0 && t->b > 0 && t->c > 0)) return false;
  if(!((t->a + t->b) >= t->c && (t->b + t->c) >= t->a && (t->a + t->c) >= t->b))
    return false;
  return true;
}

bool is_equilateral(const triangle_t t){
  if(!is_valid_triangle(&t)) return false;
  return t.a == t.b && t.b == t.c;
}

bool is_isosceles(const triangle_t t){
  if(!is_valid_triangle(&t)) return false;
  return t.a == t.b ||  t.b == t.c || t.a == t.c;
}

bool is_scalene(const triangle_t t){
  if(!is_valid_triangle(&t)) return false;
  return t.a != t.b &&  t.b != t.c && t.a != t.c;
}
