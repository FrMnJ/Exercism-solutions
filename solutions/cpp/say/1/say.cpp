#include "say.h"

namespace say {
    std::map<long long, std::string> in_word = {
        {0, "zero"},
        {1, "one"},
        {2, "two"},
        {3, "three"},
        {4, "four"},
        {5, "five"},
        {6, "six"},
        {7, "seven"},
        {8, "eight"},
        {9, "nine"},
        {10, "ten"},
        {11, "eleven"},
        {12, "twelve"},
        {13, "thirteen"},
        {14, "fourteen"},
        {15, "fifteen"},
        {16, "sixteen"},
        {17, "seventeen"},
        {18, "eighteen"},
        {19, "nineteen"},
        {20, "twenty"},
        {30, "thirty"},
        {40, "forty"},
        {50, "fifty"},
        {60, "sixty"},
        {70, "seventy"},
        {80, "eighty"},
        {90, "ninety"},
    };
    std::vector<std::string> postfixes = {
        "",
        "thousand",
        "million",
        "billion"
    };

    std::string in_english(long long number){
        if(number < 0 or number > 999'999'999'999) throw std::domain_error("Number out of range");
        std::string num_str {std::to_string(number)};
        std::vector<int> nums;
        std::string number_s{};
        for(int i = num_str.size()-1; i>=0; --i){
            number_s = num_str[i] + number_s;
            if(number_s.size()==3){
                nums.push_back(std::stoi(number_s));
                number_s = "";
            }
        }
        if(number_s != "") nums.push_back(std::stoi(number_s));
        std::string result{};
        std::string parcial{};
        for(int i = nums.size() - 1; i >= 0; --i){
            std::string postfix = postfixes[i];
            int hundreds = ((nums[i] / 10) / 10) % 10;
            int tens = (nums[i] / 10) % 10;
            int ones = nums[i] % 10;
            if(hundreds > 0){
                parcial += " " + in_word[hundreds] + " hundred";
            }
            if(tens == 1){
                int temp = 10 + ones;
                parcial = " " + in_word[temp];
            }
            else if(tens>1){
                int temp = tens * 10;
                parcial += " " + in_word[temp] +
                    (ones > 0 ? "-" + in_word[ones] : "");
            }
            else {
              if(hundreds == 0 and ones == 0 and i == 0 and result == "") return "zero";
              else if(ones > 0){
                parcial += " " + in_word[ones];
              }
            }
            result += parcial != "" ?  parcial + " " + postfix : "";
            parcial = "";
        }
        boost::algorithm::trim(result);
        return result;
    }

}  // namespace say