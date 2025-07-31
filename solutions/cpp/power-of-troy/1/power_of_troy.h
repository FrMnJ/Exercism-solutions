#pragma once

#include <string>
#include <memory>
#include <vector>

namespace troy {

struct artifact {
    // constructors needed (until C++20)
    artifact(std::string name) : name(name) {}
    std::string name;
};

struct power {
    // constructors needed (until C++20)
    power(std::string effect) : effect(effect) {}
    std::string effect;
};

class human{
    public:
        std::unique_ptr<artifact> possession;
        std::shared_ptr<power> own_power;
        std::shared_ptr<power> influenced_by;
};

    void give_new_artifact(human& human, const std::string& name);
    void exchange_artifacts(std::unique_ptr<artifact>&, std::unique_ptr<artifact>&);
    void manifest_power(human&, const std::string&);
    void use_power(const human&, human&);
    int power_intensity(const human&);
}  // namespace troy
