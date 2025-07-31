#include "list_ops.h"

// constructs a new list
list_t *new_list(size_t length, list_element_t elements[]){
 list_t *list = malloc(sizeof(list_t) + sizeof(list_element_t) * length);
 if(!list) return NULL;
 list->length = length;
 for(size_t i = 0; i < length ; ++i){
  list->elements[i] = elements[i];
 }
 return list;
}

//append entries to a list and return the new list
list_t *append_list(list_t *list1, list_t *list2){
 int length = list1->length+list2->length;
 list_t *list = new_list(length, list1->elements);
 for(size_t i = 0; i < list2->length; ++i){
  list->elements[i + list1->length] = list2->elements[i];
 }
 return list;
}

// filter list returning only values that satisfy the filter function
list_t *filter_list(list_t *list, bool (*filter)(list_element_t)){
  size_t count = 0;
  for(size_t i = 0 ; i < list->length; ++i){
    if(filter(list->elements[i])) ++count;
  }
  list_t *filtered = malloc(sizeof(list_t) + sizeof(list_element_t) * count);
  filtered->length = count;
  size_t index = 0;
  for(size_t i = 0 ; i < list->length; ++i){
    if(filter(list->elements[i])){
     filtered->elements[index++] = list->elements[i]; 
    }
  }
  return filtered;
}

// returns the length of the list
size_t length_list(list_t *list){
  return list->length;
}

// return a list of elements whose values equal the list value transformed by
// the mapping function
list_t *map_list(list_t *list, list_element_t (*map)(list_element_t)){
 list_t *mapped = malloc(sizeof(list_t) + sizeof(list_element_t) * list->length);
 mapped->length = list->length;
 for(size_t i = 0; i < list->length; i++){
  mapped->elements[i] = map(list->elements[i]);
 }
 return mapped;
}

// folds (reduces) the given list from the left with a function
list_element_t foldl_list(list_t *list, list_element_t initial, list_element_t (*foldl)(list_element_t, list_element_t)){
 for(size_t i = 0; i < list->length; i++){
  initial = foldl(initial, list->elements[i]);
 }
 return initial;
}

// folds (reduces) the given list from the right with a function
list_element_t foldr_list(list_t *list, list_element_t initial, list_element_t (*foldr)(list_element_t, list_element_t)){
 for(int i = list->length-1; i >= 0; i--){
  initial = foldr(list->elements[i], initial);
 }
 return initial;
}


// reverse the elements of the list
list_t *reverse_list(list_t *list){
 list_t *l = malloc(sizeof(list_t) + sizeof(list_element_t) * list->length);
 l->length = list->length;
 for(size_t i = 0; i < list->length; i++){
  l->elements[i] = list->elements[list->length-1-i];
 }
 return l;
}

// destroy the entire list
// list will be a dangling pointer after calling this method on it
void delete_list(list_t *list){
  free(list);
}

