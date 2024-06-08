#include "../Math-Library/pe-utils.h"
#include <stdbool.h>
#include <stdio.h>

int main() {
    long long target = 600851475143;
    long long prime = 2;
    bool keepLooping = true;

    while (keepLooping) {

        if (target % prime == 0) {
            target = target / prime;
        } else {
            prime = nextPrime(prime);
        }

        if (target == 1) {
            keepLooping = false;
        }
    }

    printf("%lld\n", prime);

    return 0;
}
