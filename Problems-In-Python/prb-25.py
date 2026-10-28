
def fib(digits_length):
    cycles = 1
    str_sum = 1
    prev = 0
    while digits_length > len(str(str_sum)):
        temp = str_sum
        str_sum += prev
        prev = temp
        cycles += 1
    print(str(str_sum))
    print("cycles: " , cycles)
fib(1000)

