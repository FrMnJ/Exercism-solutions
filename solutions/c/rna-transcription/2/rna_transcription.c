#include "rna_transcription.h"

char replace(const char *dna){
  switch(*dna){
    case 'G':
      return 'C';
    case 'C':
      return 'G';
    case 'T':
      return 'A';
    case 'A':
      return 'U';
    default:
      return '\0';
  }
}

char *to_rna(const char *dna){
 char *rna = (char *)malloc(sizeof(char) * (strlen(dna) + 1));
 char *res = rna;
 for(;*dna != '\0'; dna++, rna++){
    *rna = replace(dna);
 }
 *rna = '\0';
 return res;
}
