#include "robot_simulator.h"

robot_status_t robot_create(robot_direction_t direction, int x, int y){
  robot_status_t new_robot = {
    .direction = direction,
    .position = {
      .x = x,
      .y = y
    },
  };
  return new_robot;
}

void turn_counter_clockwise(robot_status_t *robot){
 switch(robot->direction){
  case DIRECTION_NORTH:
    robot->direction = DIRECTION_WEST;
    break;
  case DIRECTION_EAST:
    robot->direction = DIRECTION_NORTH;
    break;
  case DIRECTION_SOUTH:
    robot->direction = DIRECTION_EAST;
    break;
  case DIRECTION_WEST:
    robot->direction = DIRECTION_SOUTH;
    break;
  default: 
    break;
 }
}

void turn_clockwise(robot_status_t *robot){
 switch(robot->direction){
  case DIRECTION_NORTH:
    robot->direction = DIRECTION_EAST;
    break;
  case DIRECTION_EAST:
    robot->direction = DIRECTION_SOUTH;
    break;
  case DIRECTION_SOUTH:
    robot->direction = DIRECTION_WEST;
    break;
  case DIRECTION_WEST:
    robot->direction = DIRECTION_NORTH;
    break;
  default: 
    break;
 }
}

void advance(robot_status_t *robot){
 switch(robot->direction){
  case DIRECTION_NORTH:
    robot->position.y++;
    break;
  case DIRECTION_EAST:
    robot->position.x++;
    break;
  case DIRECTION_SOUTH:
    robot->position.y--;
    break;
  case DIRECTION_WEST:
    robot->position.x--;
    break;
  default: 
    break;
 }
}

void robot_move(robot_status_t *robot, const char *commands){
 for(; *commands ; commands++){
  switch(*commands){
    case 'R':
      turn_clockwise(robot);
      break;
    case 'L':
      turn_counter_clockwise(robot);
      break;
    case 'A':
      advance(robot);
      break;
  }
 }
}

