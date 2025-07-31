#include "reverse_string.h"

namespace reverse_string {
    std::string reverse_string(const std::string& str){
        std::string result{};
        for(int i=str.size()-1;i>=0;--i){
            result += str[i];
        }
        return result;
    }
}  // namespace reverse_string
