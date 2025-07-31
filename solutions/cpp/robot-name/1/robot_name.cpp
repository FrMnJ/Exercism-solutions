#include "robot_name.h"

namespace robot_name {
    robot::robot(){
        this->generate_name();
    }
    
    void robot::generate_name(){
        while(true){
            char first = (char)(rand()%(90-65 + 1) + 65);
            char second = (char)(rand()%(90-65 + 1) + 65);  
            char third = (char)(rand()%(57-48 + 1) + 48);
            char fourth = (char)(rand()%(57-48 + 1) + 48);
            char fifth = (char)(rand()%(57-48 + 1) + 48);
            std::string name = std::string(1, first) + second + third + fourth + fifth;
            if(this->old_names.count(name) == 0){
                this->cur_name = name;
                this->old_names.insert(name);
                return;
            }
        }
    }
    
    void robot::reset(){
        this->generate_name();
    }

}  // namespace robot_name
