"""
Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Пример:
- [2, 3, 4, 5, 6] => [12, 15, 16];
- [2, 3, 5, 6] => [12, 15]
"""

import random


def create(n):
    spis = []
    for i in range(n):
        spis.append(random.randint(0, 10))
    return spis


def comp(spis):
    res = []
    for i in range(int(len(spis) / 2 + 0.5)):
        print(i)
        res.append(spis[i] * spis[(i + 1) * (-1)])
    return res


N = input('Введите размер списка: ')
while not N.isdigit():
    N = input('Введите размер списка: ')
N = int(N)

user_list = create(N)

print(user_list, '=>', comp(user_list))
