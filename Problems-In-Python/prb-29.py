
d_set = set()

for i in range(2,101):
    for j in range(2,101):
        d_set.add(i**j)

print(len(d_set))

