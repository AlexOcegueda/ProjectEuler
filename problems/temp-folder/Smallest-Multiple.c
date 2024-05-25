#include <limits.h>
#include <stdio.h>
#include <stdbool.h> 


int main() {
    
    int INFINITY = INT_MAX;

    for (int i = 20; i < INFINITY; i++ ) {

        bool found = false;

        for (int j = 2; j <= 20; j++) {
            if (i % j != 0) {
                break;
            }

            if (j == 20) {
                printf("FOUND: %d\n",i);
                found = true;
            }
        }
        if (found) {
            break;
        }
    }

    return 0; 
}
