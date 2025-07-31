#include "pangram.h"

namespace pangram {
    bool is_pangram(std::string s){
        std::unordered_set<char> letters;
        for(size_t i = 0; i < s.size(); ++i){
            char c = std::tolower(s[i]);
            if(c>='a'&&c<='z') letters.insert(c);
            if(letters.size()>=26) return true;
        }
        return false;
    }
}  // namespace pangram
