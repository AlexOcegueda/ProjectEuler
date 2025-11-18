from collections import deque

def is_prime(n):
    if n <= 1:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

def circular_prime(x):
    q = deque(list(str(x)))
    for _ in range(len(q)):
        if not is_prime(int(''.join(q))):
            return False
        tmp = q.popleft()
        q.append(str(tmp))

    return True

def main(x):
    count = 13 # 13 primes under 100
    for i in range(x, 100, -1):
        if circular_prime(i):
            count += 1

    print(count)

x = 500
x2 = 1000000
main(x2)
