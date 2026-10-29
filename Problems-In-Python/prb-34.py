
def factorial(x):
    total = 1
    for i in range(2,x+1):
        total *= i
    return total

def main():
    total = 0
    for i in range(3, 2540160):
        s = str(i)
        c_sum = 0
        for n in s:
            c_sum += factorial(int(n))
        if c_sum == i:
            print(i)
            total += c_sum
    print(total)
main()
