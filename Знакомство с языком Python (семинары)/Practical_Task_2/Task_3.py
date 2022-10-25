"""
Задайте список из n чисел последовательности $(1+\frac 1 n)^n$ и выведите на экран их сумму.
Пример:
- Для n = 3: {1: 2.0, 2: 2.25, 3: 2.37 }
"""

n = input('Введите n: ')
while not n.isdigit():
    n = input('Введите n: ')
n = int(n)
res = {}


def create(x):
    for i in range(1, x + 1):
        res[i] = round((1 + 1 / i) ** i, 2)
    return res


def summa(x):
    s = 0
    for i in range(1, len(x) + 1):
        s += x[i]
    return s


res = create(n)

print(res)
print('Сумма = ', summa(res))
