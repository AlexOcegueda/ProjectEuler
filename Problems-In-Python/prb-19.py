sundays = 0
year = 1901
end_year = 2000
months = {
    1: 31,
    2: 28,
    3: 31,
    4: 30,
    5: 31,
    6: 30,
    7: 31,
    8: 31,
    9: 30,
    10: 31,
    11: 30,
    12: 31
}

# range of years
while (year <= end_year):
    # 1 = tuesday 2 = wednesday ... sunday = 5
    weekday = 1

    # range of months
    for i in range(1, 13):
        # feburary -- leap year check 
        if i == 2 and year % 4 == 0 and (year % 100 == 0 and year % 400 == 0):
            if weekday == 5 and :
                sundays += 1
        if weekday == 5

