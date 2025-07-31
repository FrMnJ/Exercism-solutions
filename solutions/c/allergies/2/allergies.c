#include "allergies.h"

bool is_allergic_to(allergen_t allergen, int score){
  int check = 1<<(int)allergen;
  return check & score;
}

allergen_list_t get_allergens(int score){
  allergen_list_t list = {
    .count = 0
  };
  int check = 1;
  for(allergen_t i = ALLERGEN_EGGS; i < ALLERGEN_COUNT; i++, check<<=1){
    if(score & check){
      list.allergens[i] = true;
      list.count++;
    }
  }
  return list;
}
