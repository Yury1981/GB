"""
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Пример:
- 45 -> 101101
- 3 -> 11
- 2 -> 10
"""


# def dec2bin(x):
#     global res, i
#     while x / 2 > 0:
#         res += (x % 2) * 10 ** i
#         x //= 2
#         i += 1
#     return res


def dec2bin(x):
    global res, i
    if x > 0:
        res = (x % 2) * 10 ** i
        i += 1
        return res + dec2bin(x // 2)
    return 0


N = int(input('Введите десятичное число: '))
res = 0
i = 0

print(N, '->', dec2bin(N))

