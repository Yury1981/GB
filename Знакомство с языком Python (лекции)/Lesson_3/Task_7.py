import random

listok = []

for i in range(1, 101):
    if i % 2 == 0:
        listok.append(i)

print(listok)


listok1 = []

for i in range(1, 101):
    # if i % 2 == 0:
    listok1.append(i)

print(listok1)


listok2 = [i for i in range(1, 101)]

print(listok2)



listok3 = [i for i in range(1, 101) if i % 2 == 0]

print(listok3)


listok4 = [random.randint(0, 100) for i in range(1, 101)]

print(listok4)


listok5 = [(i, i) for i in range(1, 101) if i % 2 == 0]

print(listok5)