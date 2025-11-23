from collections import deque

def is_prime(n):
    if n <= 1:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

def trucatable_primes(x):
    q = deque(list(str(x)))
    p = deque(list(str(x)))

    #left to right
    for _ in range(len(p)):
        if not is_prime(int("".join(p))):
            return False
        p.pop()

    #right to left
    for _ in range(len(q)):
        if not is_prime(int("".join(q))):
            return False
        q.popleft()

    return True

def main():
    eleven = []
    first = 11 # first prime to consider
    while len(eleven) < 11:
        if trucatable_primes(first):
            eleven.append(first)
            print(first)
        first += 1
    count = sum(eleven)
    print(count)

main()
