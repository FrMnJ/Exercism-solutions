#include "grade_school.h"

namespace grade_school {
    const std::map<int, std::vector<std::string>>& school::roster() const{
        return this->current_roster;
    }

    bool school::empty(){
        return this->current_roster.empty();
    }
    
    void school::add(const std::string& name, const int grade){
        if(this->current_roster.count(grade)){
            this->current_roster[grade].emplace_back(name);
            std::sort(this->current_roster[grade].begin(), this->current_roster[grade].end());
        }
        else{
            this->current_roster[grade] = std::vector<std::string>{name};
        }
    }

    std::vector<std::string> school::grade(int grade) const {
    auto it = current_roster.find(grade);
    if (it != current_roster.end()) {
        auto sorted_list = it->second;
        return sorted_list;
    }
    return {};
}
}  // namespace grade_school
