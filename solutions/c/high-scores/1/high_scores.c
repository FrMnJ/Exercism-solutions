#include "high_scores.h"

int compare(const void *elem1, const void *elem2){
  int32_t *a, *b;
  a = (int32_t *)elem1;
  b = (int32_t *)elem2;
  return (*b - *a);
}

int32_t latest(const int32_t *scores, size_t scores_len){
  return scores[scores_len - 1];
}

int32_t personal_best(const int32_t *scores, size_t scores_len){
  int32_t max = scores[0];
  for(size_t i = 1; i < scores_len; i++){
   if(scores[i] > max) max = scores[i];
  }
  return max;
}

size_t personal_top_three(const int32_t *scores, size_t scores_len, int32_t *output){
 int32_t *w_scores = malloc(sizeof(int32_t)*scores_len);
 memcpy(w_scores, scores, scores_len*sizeof(int32_t)); 
 qsort(w_scores, scores_len, sizeof(int32_t), compare);
 for(int i = 0; i < 3; i++){
  output[i] = w_scores[i]; 
 }
 free(w_scores);
 return scores_len > 3 ? 3 : scores_len;
}
