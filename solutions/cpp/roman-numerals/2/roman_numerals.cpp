#include "roman_numerals.h"

namespace roman_numerals {
    std::vector<std::string> ones{"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
    std::vector<std::string> tens{
    "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"
    };

    std::vector<std::string> hundreds{
        "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"
    };

    std::vector<std::string> thousands{
        "", "M", "MM", "MMM"
    };

    std::string convert(int num){
        int o = num % 10;
        int t = (num / 10) % 10;
        int h = (num / 100 ) % 10;
        int th = (num / 1000) % 10;
        std::string rth = thousands[th];
        std::string rh = hundreds[h];
        std::string rt = tens[t];
        std::string ro = ones[o];
        std::string res = rth + rh;
        res += rt;
        res += ro;
        return res;
    }
}  // namespace roman_numerals
