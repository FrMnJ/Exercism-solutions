#if !defined(ROBOT_NAME_H)
#define ROBOT_NAME_H
#include <string>
#include <unordered_set>

namespace robot_name {

    class robot{
        std::string cur_name;   
        std::unordered_set<std::string> old_names;
        public:
            robot();
            void generate_name();
            void reset();
            const std::string& name() const{
                return this->cur_name;
            }
    };

}  // namespace robot_name

#endif  // ROBOT_NAME_H