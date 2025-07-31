#if !defined(QUEEN_ATTACK_H)
#define QUEEN_ATTACK_H
#include <utility>
#include <stdexcept>
#include <exception>
#include <cmath>

namespace queen_attack {
    class chess_board{
        std::pair<int, int> black_m;
        std::pair<int, int> white_m;
        public:
            chess_board(std::pair<int, int>, std::pair<int, int>);
            std::pair<int,int> white() const;
            std::pair<int,int> black() const;
            bool can_attack() const;
    };

}  // namespace queen_attack

#endif  // QUEEN_ATTACK_H