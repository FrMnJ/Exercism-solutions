#include "power_of_troy.h"

namespace troy {
    void give_new_artifact(human& human, const std::string& name){
        human.possession = std::make_unique<artifact>(artifact{name});
    }
    
    void exchange_artifacts(std::unique_ptr<artifact>& an_artifact, std::unique_ptr<artifact>& other_artifact){
        std::swap(an_artifact, other_artifact);
    }
    void manifest_power(human& a_human, const std::string& new_power){
        a_human.own_power = std::make_shared<power>(power{new_power});
    }

    void use_power(const human& caster, human& target){
        target.influenced_by = caster.own_power;
    }

    int power_intensity(const human& a_human){
        if(a_human.own_power == nullptr) return 0;
        return a_human.own_power.use_count();
    }
}  // namespace troy
