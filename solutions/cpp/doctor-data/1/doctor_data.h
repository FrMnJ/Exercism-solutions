#pragma once
#include <string>

namespace star_map{
    enum class System{ BetaHydri, Sol, EpsilonEridani, AlphaCentauri, DeltaEridani, Omicron2Eridani  };
}

namespace heaven{
    class Vessel{
        public:
            std::string name;
            int generation;
            star_map::System current_system{star_map::System::Sol};
            int busters; 
    
            Vessel(std::string name, int generation);
            Vessel(std::string name, int generation, star_map::System system);
            Vessel replicate(std::string new_name);
            void make_buster();
            bool shoot_buster();
    };

    std::string get_older_bob(Vessel, Vessel);
    bool in_the_same_system(Vessel, Vessel);
}

