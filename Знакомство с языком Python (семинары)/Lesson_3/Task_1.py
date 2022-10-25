"""
Реализуйте алгоритм задания случайных чисел без использования встроенного генератора псевдослучайных чисел.
"""


def rand(j, k, a, b, m):
    i = 2
    while k != j:
        x = (a * k + b) % m
        if x != j:
            print(f'X{i} = ({a} * {k} + {b}) mod {m} = ', x)
            k = x
            i += 1
        else:
            k = x


n = input('Введите n: ')
while not n.isdigit():
    n = input('Введите n: ')
n = int(n)
A = 7
B = 5
M = 11

print('X0 = ', n)
y = (A * n + B) % M
print(f'X1 = ({A} * {n} + {B}) mod {M} = ', y)
rand(n, y, A, B, M)

# X0 = 0
# X1 = (7 * 0 + 5) mod 11 = 5
# X2 = (7 *  5 + 5) mod 11 = 40 mod 11 = 7
# X3 = (7 * 7 + 5) mod 11 = 54 mod 11 = 10
# X4 = (7 * 10 + 5) mod 11 = 75 mod 11 = 9
# X5 = (7 * 9 + 5) mod 11 = 68 mod 11 = 2
# X6 = (7 * 2 + 5) mod 11 = 19 mod 11 = 8
# X7 = (7 * 8 + 5) mod 11 = 61 mod 11 = 6
# X8 = (7 * 6 + 5) mod 11 = 47 mod 11 = 3
# X9 = (7 * 3 + 5) mod 11 = 26 mod 11 = 4
# X10 = (7 *  4 + 5) mod 11 = 33 mod 11 = 0
