#include "hamming.h"

namespace hamming {
    int compute(std::string_view dna, std::string_view other){
        if(dna.size()!=other.size()) throw std::domain_error("DNA strings must be of the same length");
        int counter_differences = 0;
        for(size_t i=0;i<dna.size();++i){
            if(dna[i]!=other[i]) ++counter_differences;
        }
        return counter_differences;
    }
}  // namespace hamming
