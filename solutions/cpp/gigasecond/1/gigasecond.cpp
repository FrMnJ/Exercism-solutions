#include "gigasecond.h"

namespace gigasecond {
    
    ptime advance(ptime start){
        time_duration td = seconds(1'000'000'000);
        return start + td;
    }

}  // namespace gigasecond
