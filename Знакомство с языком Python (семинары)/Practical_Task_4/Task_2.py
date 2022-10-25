""""
Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
"""


def prime_factors(x):
    i = 2
    spis = []
    while i * i <= x:
        while x % i == 0:
            spis.append(i)
            x = int(x / i)
        i += 1
    if x > 1:
        spis.append(x)
    return spis


N = input('Введите число N: ')
while not N.isdigit() or N == '0' or N == '1':
    N = input('Введите число N: ')
N = int(N)

if len(prime_factors(N)) == 1:
    print(f"{N} - это простое число!")
else:
    print(prime_factors(N))
