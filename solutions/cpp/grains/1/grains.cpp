#include "grains.h"

namespace grains {
    unsigned long long square(int x){
        return (1ULL<<(x-1));
    }

    unsigned long long total(){     
        return (1ULL << 63) * 2 - 1;
    }
}  // namespace grains
