#include <stdio.h>
#include "../Math-Library/pe-utils.h"

// prototype

int main() {

    long long goal = 10001;
    long long start = 1;

    for (int i = 1; i <= goal; i++) {
        start = nextPrime(start); 
        if (i <= 6) {
            printf("Check: %lld, i: %d\n", start, i);
        }       
    }


    printf("Total: %lld\n", start);

}
