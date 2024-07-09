#include <stdio.h>

int main() {

    int result = 0;
    int goal = 1000;

    // 3 or 5
    for (int i = 0; i < goal; i++) {
        if (i % 3 == 0 || i % 5 == 0) {
            result += i;
        }
    }
    
    printf("Result: %d\n", result);

    return 0; 
}

