#include "nucleotide_count.h"

namespace nucleotide_count {
    const std::map<char, int> count(const std::string_view dna){
        std::map<char, int> counter{ {'A', 0}, {'C', 0}, {'G', 0}, {'T', 0} };
        for(char c: dna){
            if(c=='A' or c=='C' or c=='G' or c=='T') ++counter[c];
            else throw std::invalid_argument("dna must only contain A, C, G or T");
        }
        return counter;
    }
}  // namespace nucleotide_count
