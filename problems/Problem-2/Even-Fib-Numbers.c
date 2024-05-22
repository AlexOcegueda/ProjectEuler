#include <stdio.h>

// prototype
void fib(int *a, int *b);

int main() {

    int MAX = 4000000;
    int a = 0;
    int b = 1;
    int sum = 0;

    while (a < MAX) {
        if (a % 2 == 0) {
            sum += a;
        }
        fib(&a, &b);
    }
    
    printf("Result: %d\n", sum);

    return 0; 
}

void fib(int *a, int *b) {
    int c = *a + *b;
    *a = *b;
    *b = c;

}