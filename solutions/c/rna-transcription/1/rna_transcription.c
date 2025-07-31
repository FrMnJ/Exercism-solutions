#include "rna_transcription.h"

char *to_rna(const char *dna){
 int len_dna = strlen(dna);
 char *rna = malloc(sizeof(char) * (len_dna + 1));
 char *res = rna;
 for(;*dna != '\0'; dna++, rna++){
  switch(*dna){
    case 'G':
      *rna = 'C';
      break;
    case 'C':
      *rna = 'G';
      break;
    case 'T':
      *rna = 'A';
      break;
    case 'A':
      *rna = 'U';
      break;
  }
 }
 *rna = '\0';
 return res;
}
