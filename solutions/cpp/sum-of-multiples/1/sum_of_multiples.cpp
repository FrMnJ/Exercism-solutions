#include "sum_of_multiples.h"

namespace sum_of_multiples {

int to(std::vector<int> items, int level){
    std::set<int> mults = {};
    int res = 0;
    for(std::size_t i = 0; i < items.size(); ++i){
        for(int j = items[i] ; j < level; j += items[i]){
            if(j < level) {
                mults.insert(j);
            }
        }
    }
    for(int mult : mults){
        res += mult;
    }
    return res;
}

}  // namespace sum_of_multiples
