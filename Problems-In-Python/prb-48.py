sum = 0
for i in range(1000, 0, -1):
    sum += i**i

tail =str(sum)[-10:]
print(tail)
