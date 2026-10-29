
match = 0

total = 0
for i in range(10, 354294):
    nums = [int(x) for x in str(i)]
    num_sum = 0
    for n in nums:
        num_sum += int(n)**5
    if num_sum == i:
        total += num_sum

print(total)
