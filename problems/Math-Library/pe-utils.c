#include "pe-utils.h"
#include <stdbool.h>

/*
 * File: pe-utils.c
 * Description: This file contains common math operations used to complete Project Euler problems.
 *              It is made for educational purposes and is aware of the Math Library.
 * Author: Alex Ocegueda
 * Date: June 7, 2024
 */

/*
 * Function: power
 * ----------------------------
 *   Computes the power of a number.
 *
 *   x: The base number.
 *   exponent: The exponent to raise the base to.
 *
 *   returns: The result of x raised to the power of exponent.
 */
int power(int x, int exponent) {
    int result = 1;

    for (int i = 0; i < exponent; i++) { 
        result *= x;
    }

    return result;
}

/*
 * Function: floorValue
 * ----------------------------
 *   Computes the floor value of a floating-point number.
 *
 *   start: The floating-point number to floor.
 *
 *   returns: The largest integer less than or equal to the start.
 */
long long floorValue(float start) {
    int intPart = (int) start;

    if (start >= 0 || start == intPart) {
        return intPart;
    } else {
        return intPart - 1;
    }
}

/*
 * Function: roundValue
 * ----------------------------
 *   Rounds a floating-point number to the nearest integer.
 *
 *   start: The floating-point number to round.
 *
 *   returns: The nearest integer to start.
 */
long long roundValue(float start) {
    int intPart = (int) start;
    float fractionalPart = start - intPart;
    
    if (fractionalPart < 0) {
        fractionalPart = -fractionalPart;
    }
    
    int leadNum = (int)(fractionalPart * 10);
    
    if (start > 0) {
        if (leadNum < 5) {
            return intPart;
        } else {
            return intPart + 1;
        }
    } else {
        if (leadNum < 5) {
            return intPart;
        } else {
            return intPart - 1;
        }
    }
}

/*
 * Function: absoluteValue
 * ----------------------------
 *   Computes the absolute value of a long long integer.
 *
 *   start: The long long integer to compute the absolute value of.
 *
 *   returns: The absolute value of start.
 */
long long absoluteValue(long long start) {
    return (start < 0) ? -start : start;
}

/*
 * Function: absoluteFloat
 * ----------------------------
 *   Computes the absolute value of a floating-point number.
 *
 *   start: The floating-point number to compute the absolute value of.
 *
 *   returns: The absolute value of start as a float.
 */
float absoluteFloat(long long start) {
    return (start < 0) ? -start : start;
}

/*
 * Function: squareRoot
 * ----------------------------
 *   Computes the square root of a long long integer using Heron's method.
 *
 *   start: The long long integer to compute the square root of.
 *
 *   returns: The square root of start as a float.
 */
float squareRoot(long long start) {
    float guess = start * .25;
    float prev = 0;
    float difference = 0;
    float tolerance = .000001;
    
    do {
        guess = .5 * (guess + start / guess);
        difference = absoluteFloat(prev - guess) / absoluteFloat(guess);
        prev = guess;
    } while (difference > tolerance);

    return guess;
}

/*
 * Function: isPrime
 * ----------------------------
 *   Determines if a long long integer is prime.
 *
 *   start: The long long integer to check for primality.
 *
 *   returns: true if start is a prime number, false otherwise.
 */
bool isPrime(long long start) {
    if (start <= 1) {
        return false;
    }

    if (start <= 3) {
        return true;
    }

    if (start % 2 == 0 || start % 3 == 0) {
        return false;
    }

    long long end = floorValue(squareRoot(start));

    for (long long i = 5; i <= end; i += 6) {
        if (start % i == 0 || start % (i + 2) == 0) {
            return false;
        }
    }
    return true;
}

/*
 * Function: nextPrime
 * ----------------------------
 *   Finds the next prime number greater than a given start.
 *
 *   start: The starting long long integer.
 *
 *   returns: The next prime number greater than start.
 */
long long nextPrime(long long start) {
    if (start <= 1) {
        return 2;
    }

    do {
        start++;
    } while (!isPrime(start));

    return start;
}
