#include "etl.h"

namespace etl {

std::map<char, int> transform(const std::map<int, std::vector<char>>& points_table) {
    std::map<char, int> res {};
    for (const auto& [key, letters] : points_table) {
        for (char l : letters) {
            res[std::tolower(l)] = key;
        }
    }
    return res;
}


}  // namespace etl
