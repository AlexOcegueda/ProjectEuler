package main

import (
    "fmt"
)

func main() {
    fmt.Println("Number Letter Counts")

    words := map[int]string{
        0:  "",
        1:  "one",
        2:  "two",
        3:  "three",
        4:  "four",
        5:  "five",
        6:  "six",
        7:  "seven",
        8:  "eight",
        9:  "nine",
        10: "ten",
        11: "eleven",
        12: "twelve",
        13: "thirteen",
        14: "fourteen",
        15: "fifteen",
        16: "sixteen",
        17: "seventeen",
        18: "eighteen",
        19: "nineteen",
        20: "twenty",
        30: "thirty",
        40: "forty",
        50: "fifty",
        60: "sixty",
        70: "seventy",
        80: "eighty",
        90: "ninety",
        1000: "onethousand", 
    }

    letterCount := 0
    numberRange := 1000 // 1000 is Max

    for i := 1; i <= numberRange; i++ {
        value, exists := words[i]

        if exists {
            // Direct lookup for numbers in the map
            letterCount += len(value)
        } else {
            // Handle numbers not directly in the map
            if i >= 100 {
                hundreds := i / 100
                remainder := i % 100

                // Add "X hundred"
                letterCount += len(words[hundreds]) + len("hundred")

                if remainder != 0 {
                    // Add "and" only if there's a remainder
                    letterCount += 3
                }

                if remainder < 20 {
                    // Use direct words for numbers < 20
                    letterCount += len(words[remainder])
                } else {
                    tens := remainder / 10
                    ones := remainder % 10
                    letterCount += len(words[tens*10]) + len(words[ones])
                }
            } else {
                // Handle numbers < 100
                tens := i / 10
                ones := i % 10
                letterCount += len(words[tens*10]) + len(words[ones])
            }
        }
    }

    fmt.Println("Letter Count for Range: ", letterCount)
}
