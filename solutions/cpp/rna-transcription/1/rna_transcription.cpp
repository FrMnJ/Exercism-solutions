#include "rna_transcription.h"

namespace rna_transcription {
    char to_rna(char dna){
        switch(dna){
            case 'G':
                return 'C';
             case 'C':
                return 'G';
             case 'T':
                return 'A';
             case 'A':
                return 'U';
            default:
                throw std::invalid_argument("invalid dna char");
        }
    }
    
    std::string to_rna(const std::string_view dna){
        std::string result{};
        for(char c : dna){
            result += to_rna(c);
        }
        return result;
    }
}  // namespace rna_transcription
