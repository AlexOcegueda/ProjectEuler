package main

import (
    "fmt"
    "projecteuler/mathlibrary"
    "math/big"
)
/*
    Explanation: 
        To go from 1 corner to the opposite corner in a YxY square you'd need to go right
        Y times and go down Y times. The real question is how many combinations of going 
        right Y times and down Y times there is. 

        Example: In the 2x2 grid you already know 2 right and 2 down movements with a total
        of 4 movements. This means in 4 spots _ _ _ _ you need to find combinations of where
        to put your 2 R's and 2 D's. You can do this manually by putting an R in the first spot
        then another R in every other spot and count the combinations. Eventually you move on to 
        skipping the 1st spot and put the R in the 2nd spot and repeat ignoring combinations you 
        already counted.

        The formula is C(4,2) or how many random spots, where order doesn't matter, can you place
        R in 4 spots. C(x, y) function is x!/y!(x-y)!.
*/
func main() {
    fmt.Println("Lattice Paths")

    grid_x := 40
    grid_y := 20

    numerator := mathlibrary.Factorial(grid_x)
    denominator := new(big.Int).Mul(mathlibrary.Factorial(grid_y), mathlibrary.Factorial(grid_x - grid_y))
    
    result := new(big.Int).Div(numerator, denominator)
    fmt.Println(result)

}

