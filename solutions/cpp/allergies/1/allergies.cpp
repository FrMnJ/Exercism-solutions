#include "allergies.h"

namespace allergies {
    std::vector<std::string> items{
        "eggs",
        "peanuts",
        "shellfish",
        "strawberries",
        "tomatoes",
        "chocolate",
        "pollen",
        "cats"
    };
    
    allergy_test::allergy_test(int test){
        for(int n = 0; n < 8; ++n){
            if(test&(1<<n)){
                this->results.insert(items[n]);
            }
        }
    }

    bool allergy_test::is_allergic_to(const std::string& test){
        for(const std::string& item : this->results){
            if(test == item){
                return true;
            }
        }
        return false;
    }
}  // namespace allergies
