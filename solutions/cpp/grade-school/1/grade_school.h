#if !defined(GRADE_SCHOOL_H)
#define GRADE_SCHOOL_H
#include <map>
#include <vector>
#include <string>
#include <algorithm>

namespace grade_school {
    class school{
        std::map<int, std::vector<std::string>> current_roster;
        public:
            const std::map<int, std::vector<std::string>>& roster() const;
            bool empty();
            void add(const std::string& name, const int grade);
            std::vector<std::string> grade(int grade) const;
    };
}  // namespace grade_school

#endif // GRADE_SCHOOL_H