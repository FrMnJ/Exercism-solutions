#include "queen_attack.h"

attack_status_t can_attack(position_t queen_1, position_t queen_2){
  // The same position is invalid
  if(queen_1.row == queen_2.row && queen_1.column == queen_2.column) return INVALID_POSITION;
  // Range 0 to 7
  if(queen_1.row > 7 || queen_1.column > 7 || queen_2.row > 7 || queen_2.column > 7) return INVALID_POSITION;
  // The same column or row
  if((queen_1.row == queen_2.row) || (queen_1.column == queen_2.column)) return CAN_ATTACK;
  // In diagonal
  if(abs(queen_1.column - queen_2.column) == abs(queen_1.row - queen_2.row)) return CAN_ATTACK;

  return CAN_NOT_ATTACK;
}
