#if !defined(ROMAN_NUMERALS_H)
#define ROMAN_NUMERALS_H
#include <vector>
#include <string>

namespace roman_numerals {
    extern std::vector<std::string> ones;
    extern std::vector<std::string> tens;
    extern std::vector<std::string> hundreds;
    extern std::vector<std::string> thousands;
    std::string convert(int);
}  // namespace roman_numerals

#endif  // ROMAN_NUMERALS_H