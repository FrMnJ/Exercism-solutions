#if !defined(SECRET_HANDSHAKE_H)
#define SECRET_HANDSHAKE_H
#include <vector>
#include <string>

namespace secret_handshake {
    extern std::vector<std::string> actions;
    std::vector<std::string> commands(int);

}  // namespace secret_handshake

#endif  // SECRET_HANDSHAKE_H
