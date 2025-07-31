#ifndef PANGRAM_H
#define PANGRAM_H

#include <stdbool.h>
#include <stdint.h>
#include <ctype.h>

#define FULLSET ((1 << 26) - 1)
bool is_pangram(const char *sentence);

#endif
