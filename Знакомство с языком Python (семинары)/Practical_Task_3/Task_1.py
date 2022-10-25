"""
Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
Пример:
- [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
"""

import random


def create(n):
    spis = []
    for i in range(n):
        spis.append(random.randint(0, 10))
    return spis


def neg_pos(spis):
    res = []
    for i in range(1, len(spis), 2):
        res.append(spis[i])
    return res


def summa(spis):
    res = 0
    for i in range(len(spis)):
        res += spis[i]
    return res


N = input('Введите размер списка: ')
while not N.isdigit():
    N = input('Введите размер списка: ')
N = int(N)

user_list = create(N)
pos = neg_pos(user_list)

print(f'{user_list} -> на нечётных позициях элементы {pos}, ответ: {summa(pos)}')
