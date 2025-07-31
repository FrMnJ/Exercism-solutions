#include "binary_search.h"

const int *binary_search(int value, const int *arr, size_t length){
  if(length == 0) return NULL;
  int low = 0;
  int high = length;
  while(high >= low){
    int mid = (low + high) / 2;
    if(arr[mid] == value){
      return &arr[mid];
    }
    else if(value < arr[mid]) high = mid - 1;
    else low = mid + 1;
  }
  return NULL;
}
