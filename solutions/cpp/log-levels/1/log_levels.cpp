#include <string>

namespace log_line {
std::string message(std::string line) {
    return line.substr(line.find(" ")+1);
}

std::string log_level(std::string line) {
    int startIndex = line.find("[")+1;
    return line.substr(startIndex, line.find("]") - startIndex);
}

std::string reformat(std::string line) {
    return message(line) + " (" + log_level(line) + ")";
}
}  // namespace log_line
