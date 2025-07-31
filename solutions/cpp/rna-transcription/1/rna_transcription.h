#if !defined(RNA_TRANSCRIPTION_H)
#define RNA_TRANSCRIPTION_H
#include <string_view> 
#include <string>
#include <stdexcept>
#include <exception>

namespace rna_transcription {
    char to_rna(char);
    std::string to_rna(const std::string_view);
}  // namespace rna_transcription

#endif // RNA_TRANSCRIPTION_H