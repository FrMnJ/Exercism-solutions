#if !defined(SAY_H)
#define SAY_H
#include <string>
#include <map>
#include <vector>
#include <boost/algorithm/string.hpp>
#include <stdexcept>
#include <exception>

namespace say {
    extern std::map<long long, std::string> in_word;
    extern std::vector<std::string> postfixes;
    std::string in_english(long long);

}  // namespace say

#endif  // SAY_H