#include "roman_numerals.h"

namespace roman_numerals {
    std::map<int, std::string> ones{
        {0, ""},
        {1, "I"},
        {2, "II"},
        {3, "III"},
        {4, "IV"},
        {5, "V"},
        {6, "VI"},
        {7, "VII"},
        {8, "VIII"},
        {9, "IX"},
    };
    std::map<int, std::string> tens{
        {0, ""},
        {1, "X"},
        {2, "XX"},
        {3, "XXX"},
        {4, "XL"},
        {5, "L"},
        {6, "LX"},
        {7, "LXX"},
        {8, "LXXX"},
        {9, "XC"},
    };
    std::map<int, std::string> hundreds{
        {0, ""},
        {1, "C"},
        {2, "CC"},
        {3, "CCC"},
        {4, "CD"},
        {5, "D"},
        {6, "DC"},
        {7, "DCC"},
        {8, "DCCC"},
        {9, "CM"},
    };
    std::map<int, std::string> thounsands{
        {0, ""},
        {1, "M"},
        {2, "MM"},
        {3, "MMM"},
    };

    std::string convert(int num){
        int o = num % 10;
        int t = (num / 10) % 10;
        int h = (num / 100 ) % 10;
        int th = (num / 1000) % 10;
        std::string rth = thounsands[th];
        std::string rh = hundreds[h];
        std::string rt = tens[t];
        std::string ro = ones[o];
        std::string res = rth + rh;
        res += rt;
        res += ro;
        return res;
    }
}  // namespace roman_numerals
