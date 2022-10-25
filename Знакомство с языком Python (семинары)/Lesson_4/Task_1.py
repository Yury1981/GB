"""
Задайте строку из набора чисел. Напишите программу, которая покажет большее и меньшее число. В качестве
символа-разделителя используйте пробел.
Пример
"12 346 62 34 9 25623 42 34" -> 25623, 9
"""

import random


def create(n):
    spis = []
    for k in range(n):
        spis.append(random.randint(0, 99))
    return spis


def minmax(spis):
    min_vol = spis[0]
    max_vol = spis[1]
    if min_vol > max_vol:
        temp = min_vol
        min_vol = max_vol
        max_vol = temp
    for m in range(2, len(spis)):
        if spis[m] < min_vol:
            min_vol = spis[m]
        elif spis[m] > max_vol:
            max_vol = spis[m]
    return min_vol, max_vol


N = input('Введите размер списка: ')
while not N.isdigit():
    N = input('Введите размер списка: ')
N = int(N)

user_list = create(N)
x, y = minmax(user_list)

print('"', end='')
for i in range(len(user_list) - 1):
    print(f'{user_list[i]} ', end='')
print(f'{user_list[len(user_list) - 1]}"', end='')
print(f" -> {y}, {x}")
