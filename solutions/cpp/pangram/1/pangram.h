#if !defined(PANGRAM_H)
#define PANGRAM_H
#include <unordered_set>
#include <string>
#include <cctype>
namespace pangram {
    bool is_pangram(std::string);
}  // namespace pangram

#endif // PANGRAM_H