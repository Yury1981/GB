""""
Задайте последовательность чисел.
Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
"""

import random


def create(n):
    spis = []
    for i in range(n):
        spis.append(random.randint(0, 10))
    return spis


def unique(spis):
    new_spis = [spis[0]]
    for i in range(1, len(spis)):
        if spis[i] not in new_spis:
            new_spis.append(spis[i])
        else:
            continue
    return new_spis


N = input('Введите размер списка: ')
while not N.isdigit():
    N = input('Введите размер списка: ')
N = int(N)

user_list = create(N)

print(user_list)
print(unique(user_list))
