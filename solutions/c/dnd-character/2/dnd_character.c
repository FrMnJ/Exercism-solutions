#include "dnd_character.h"

int modifier(int score){
  return floor((score - 10) / 2.0);
}

int compare(const void* a, const void* b) {
   return (*(int*)a - *(int*)b);
}

int ability(void){
  int result = 0;
  int min_r = 6;
  for(int i = 0; i < 4; i++){
    int r = (rand() % 6) + 1;
    if(r < min_r)
      min_r = r;
    result += r;
  }
  return result - min_r;
}

dnd_character_t make_dnd_character(void){
  dnd_character_t new_character;
  new_character.strength = ability();
  new_character.dexterity = ability();
  new_character.constitution = ability();
  new_character.intelligence = ability();
  new_character.wisdom = ability();
  new_character.charisma = ability();
  new_character.hitpoints = 10 + modifier(new_character.constitution);
  return new_character;
}
