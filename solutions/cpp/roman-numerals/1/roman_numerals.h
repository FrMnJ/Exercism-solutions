#if !defined(ROMAN_NUMERALS_H)
#define ROMAN_NUMERALS_H
#include <map>
#include <string>

namespace roman_numerals {
    extern std::map<int, std::string> ones;
    extern std::map<int, std::string> tens;
    extern std::map<int, std::string> hundreds;
    extern std::map<int, std::string> thounsands;
    std::string convert(int);
}  // namespace roman_numerals

#endif  // ROMAN_NUMERALS_H