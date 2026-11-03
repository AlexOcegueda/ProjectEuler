import math

def is_prime(n):
    if n <= 1:
        return False
    for i in range(2, int(math.isqrt(n)) + 1):
        if n % i == 0:
            return False
    return True

def main():

    for i in range(1, 987654322):
        if is_prime(i):
            length = 0

            for j in range(1, len(str(i))+1):
                if str(j) in str(i):
                    length += 1

            if length == len(str(i)):
                 print(i)
main()
