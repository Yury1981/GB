"""
Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
Пример:
- [1.1, 1.2, 3.1, 5, 10.01] => 0.19 - ошибка в примере. "Задайте список из вещественных чисел."
"""

import random


def create(n):
    spis = []
    for i in range(n):
        spis.append(random.randint(0, 99) + random.randint(0, 10) / 100)
    return spis


def drob(x):
    return round(x - x // 1, 3)


def minmax(spis):
    min = drob(spis[0])
    max = drob(spis[1])
    if min > max:
        temp = min
        min = max
        max = temp
    for i in range(2, len(spis)):
        if drob(spis[i]) < min:
            min = drob(spis[i])
        elif drob(spis[i]) > max:
            max = drob(spis[i])
    return min, max


N = input('Введите размер списка: ')
while not N.isdigit():
    N = input('Введите размер списка: ')
N = int(N)

user_list = create(N)
x, y = minmax(user_list)
print(user_list, '=>', round(y - x, 3))
