"""
Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
Пример:
- для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
"""


# def fib(x):
#     f0 = 0
#     f1 = 1
#     res = [0, 1]
#     for i in range(x - 1):
#         f = f0 + f1
#         f0 = f1
#         f1 = f
#         res.append(f)
#     return res
#
#
# def neg_fib(x):
#     res = []
#     for i in range(x):
#         if x % 2 == 0:
#             f = (-1) ** (i + 1) * fib(x)[x - i]
#         else:
#             f = (-1) ** (i + 2) * fib(x)[x - i]
#         res.append(f)
#     return res
#
#
# N = int(input('Введите число: '))
#
# print(neg_fib(N) + fib(N))


def fib(n):
    if n <= 1:
        return n
    else:
        return fib(n - 1) + fib(n - 2)


def neg_fib(n):
    if n <= 1:
        return n
    else:
        return neg_fib(n - 2) - neg_fib(n - 1)


N = int(input('Введите число: '))
res = []
neg_res = []

for i in range(2, N + 1):
    res.append(fib(i))

for i in range(2, N + 1):
    neg_res.append(neg_fib(i))

print(neg_res[::-1] + [1, 0, 1] + res)
