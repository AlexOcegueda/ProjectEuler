package mathlibrary

import "math/big"

func Factorial(num int) *big.Int {

    result := big.NewInt(1)
    for i := 2; i <= num; i++ {
        result.Mul(result, big.NewInt(int64(i)))
    }
    return result
}
