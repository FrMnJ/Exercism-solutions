#include "queen_attack.h"

namespace queen_attack {

    chess_board::chess_board(std::pair<int, int> white, std::pair<int, int> black){
        if(white.first<0||black.first<0) throw std::domain_error("must not be negative");
        if(white.first>7||black.first>7) throw std::domain_error("must not be greater than 7");
        if(white.second<0||black.second<0) throw std::domain_error("must not be negative");
        if(white.second>7||black.second>7) throw std::domain_error("must not be greater than 7");
        if(white == black) throw std::domain_error("must be distinct");
        this->white_m = white;
        this->black_m = black;
    }

    std::pair<int,int> chess_board::white() const{
        return this->white_m;
    }
    
    std::pair<int,int> chess_board::black() const{
        return this->black_m;
    }

    bool chess_board::can_attack() const{
        bool same_row = black_m.first == white_m.first;
        bool same_col = black_m.second == white_m.second;
        bool same_diag = std::abs(black_m.first - white_m.first) == std::abs(black_m.second - white_m.second);
        return same_row or same_col or same_diag;
    }
    
}  // namespace queen_attack
