#include "pe-utils.h"

int power(int x, int exponent) {
    int result = 1;

    for (int i = 0; i < exponent; i++) { 
        result *= x;
    }

    return result;
}