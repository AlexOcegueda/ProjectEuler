
def factorial(n):
    sum = n
    for i in range(1, n):
        sum *= i
    return sum

def add_nums(x):
    s = str(x)
    sum = 0
    for c in s:
        sum += int(c)
    return sum
print(add_nums(factorial(100)))
