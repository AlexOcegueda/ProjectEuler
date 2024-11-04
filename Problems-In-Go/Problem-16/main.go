package main

import (
    "fmt"
    "math/big"
)

func main() {
    fmt.Println("Power Digit Sum")

    // Calculate 2^1000 using big.Int
    result := new(big.Int).Exp(big.NewInt(2), big.NewInt(1000), nil)

    numStr := result.String()

    output := 0
    // adding all digits together
    for _, char := range numStr {
        digit := int(char - '0') // Convert char to int
        output += digit
    }

    fmt.Println("Answer:", output)
}
