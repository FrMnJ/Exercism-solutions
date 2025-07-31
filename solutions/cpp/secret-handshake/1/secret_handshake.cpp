#include "secret_handshake.h"

namespace secret_handshake {
std::vector<std::string> actions{
  "wink",
  "double blink",
  "close your eyes",
  "jump",
};
std::vector<std::string> commands(int number){
    std::vector<std::string> res;
    if(number&(1<<4)){
        for(int n = 4; n >= 0 ; --n){
            if(number&(1<<(n-1))){
                res.push_back(actions[n-1]);
            }
        }
    }
    else{
        for(int n = 1; n <= 4 ; ++n){
            if(number&(1<<(n-1))){
                res.push_back(actions[n-1]);
            }
        }
    }
    return res;
}

}  // namespace secret_handshake
