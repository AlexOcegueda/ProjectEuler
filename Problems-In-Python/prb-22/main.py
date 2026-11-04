
total = 0

with open("names.txt", "r", encoding="utf-8") as file:
    raw = file.readline().strip()

    names = sorted(raw.replace('"', '').split(","))

    for index, name in enumerate(names, start=1):
        score = 0

        for i in range(len(name)):
            score += abs(ord(name[i]) - ord('A')) + 1
        total += (index * score)

print("Final Total:", total)

