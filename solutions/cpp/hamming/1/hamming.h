#if !defined(HAMMING_H)
#define HAMMING_H
#include <string_view>
#include <stdexcept>
#include <exception>

namespace hamming {
    int compute(std::string_view dna, std::string_view other);
}  // namespace hamming

#endif // HAMMING_H