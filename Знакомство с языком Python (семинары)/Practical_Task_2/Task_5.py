"""
Реализуйте алгоритм перемешивания списка.
"""

import random


def rand(x, y):  # Возврат рандомного числа в заданных пределах
    b = random.randint(x, y)
    return b


N = input('Введите размер списка: ')
while not N.isdigit():
    N = input('Введите размер списка: ')
N = int(N)

nums = []
for i in range(N):
    a = rand(1, 100)
    nums.append(a)

print(nums, '- Начальный список')

smes1 = random.sample(nums, len(nums))

print(smes1, '- Простое перемешивание при помощи random.sample')

temp = nums.copy()  # Копия начального списка
smes2 = []  # Перемешанный список
while len(temp) > 0:  # Цикл: Пока в списке есть элементы
    n = rand(0, len(temp) - 1)  # рандомно извлекаем элемент
    smes2.append(temp[n])  # добавляем его в новый список
    temp.pop(n)  # удаляем его из начального списка, чтобы исключить дубли и сократить размер начального списка

print(smes2, '- Перемешивание через рандомное извлечение элементов из начального списка')
