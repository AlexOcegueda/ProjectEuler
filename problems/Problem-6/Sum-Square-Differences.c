#include <stdio.h>
#include "../Math-Library/pe-utils.h"

// prototype

int main() {

    int goal = 100;
    int sumOfSquares = 0; // (1^2 + 2^2 + 3^2 ...)
    int sumOfNumbers = 0; // (1 + 2 + 3 ...)

    // calculate sum of squares 
    for(int i = 1; i <= goal; i++) {
        int x = power(i, 2); // squares num
        sumOfSquares += x;
    }

    // calculate sum of numbers
    for(int i = 1; i <= goal; i++) {
        sumOfNumbers += i;
    }

    int difference = power(sumOfNumbers, 2) - sumOfSquares;

    //printf("squareOfSum: %d\n", sumOfNumbers);
    //printf("sumOfSquares: %d\n", sumOfSquares);
    printf("Total: %d\n", difference);

}
