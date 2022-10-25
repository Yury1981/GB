"""
Найдите корни квадратного уравнения Ax² + Bx + C = 0, где A ≠ 0 двумя способами:
1) с помощью математических формул нахождения корней квадратного уравнения
2) с помощью дополнительных библиотек Python
test_data = [
    [[1, -3, 2], [1.0, 2.0]],
    [[1, 2, 1], [-1, -1]],
    [[2, 2, 1], []]
]
for nums, expected in test_data:
    assert quadratic_equation(*nums) == expected
"""

import math


# def quadratic_equation(a, b, c):
#     d = discrim(a, b, c)
#     if d > 0:
#         x1 = (-b + d ** 0.5) / 2 * a
#         x2 = (-b - d ** 0.5) / 2 * a
#         return f"корни = {x1}, {x2}"
#     elif d == 0:
#         x = (-b + d ** 0.5) / 2 * a
#         return f"корень = {x}"
#     else:
#         return "нет корней"


def discrim(a, b, c):
    d = b ** 2 - 4 * a * c
    return d


def znak(x):
    if x < 0:
        return ''
    else:
        return '+'


def quadratic_equation(a, b, c):
    d = discrim(a, b, c)
    if d > 0:
        x1 = (-b - math.sqrt(d)) / 2 * a
        x2 = (-b + math.sqrt(d)) / 2 * a
        return f"корни = {x1}, {x2}"
    elif d == 0:
        x = (-b + math.sqrt(d)) / 2 * a
        return f"корень = {x}"
    else:
        return "нет корней"


def discrim(a, b, c):
    d = b ** 2 - 4 * a * c
    return d


A = int(input('Введите A: '))
B = int(input('Введите B: '))
C = int(input('Введите C: '))

print(f"Для уравнения {A}x²{znak(B)}{B}x{znak(C)}{C}=0 {quadratic_equation(A, B, C)}")
