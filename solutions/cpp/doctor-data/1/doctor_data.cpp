#include "doctor_data.h"

heaven::Vessel::Vessel(std::string name, int generation){
    this->name = name;
    this->generation = generation;
}

heaven::Vessel::Vessel(std::string name, int generation, star_map::System system){
    this->name = name;
    this->generation = generation;
    this->current_system = system;
}

heaven::Vessel heaven::Vessel::replicate(std::string new_name){
    return heaven::Vessel{new_name, ++this->generation};
}

void heaven::Vessel::make_buster(){
    this->busters++;
}

bool heaven::Vessel::shoot_buster(){
    if(this->busters>0){
        --this->busters;
        return true;
    }
    return false;
}

std::string heaven::get_older_bob(Vessel vessel, Vessel other_vessel){
    if(vessel.generation<other_vessel.generation){
        return vessel.name;
    }
    return other_vessel.name;
}

bool heaven::in_the_same_system(Vessel vessel, Vessel other_vessel){
    return vessel.current_system == other_vessel.current_system;
}