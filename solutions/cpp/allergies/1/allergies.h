#if !defined(ALLERGIES_H)
#define ALLERGIES_H
#include <unordered_set>
#include <vector>
#include <string>

namespace allergies {
    extern std::vector<std::string> items;
    class allergy_test{
        std::unordered_set<std::string> results;
        public: 
            allergy_test(int);
            bool is_allergic_to(const std::string&);
            std::unordered_set<std::string> get_allergies(){
                return this->results;
            }
    };

}  // namespace allergies

#endif  // ALLERGIES_H