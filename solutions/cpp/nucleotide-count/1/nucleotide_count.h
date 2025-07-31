#if !defined(NUCLEOTIDE_COUNT_H)
#define NUCLEOTIDE_COUNT_H
#include <map>
#include <string>
#include <string_view>
#include <stdexcept>
#include <exception>

namespace nucleotide_count {
    const std::map<char, int> count(const std::string_view dna);
}  // namespace nucleotide_count

#endif // NUCLEOTIDE_COUNT_H