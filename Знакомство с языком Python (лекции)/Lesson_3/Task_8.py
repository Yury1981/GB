import random


def f(x):
    return x ** 3


listok5 = [(i, f(i)) for i in range(1, 101) if i % 2 == 0]
print(listok5)


listok5 = {i: random.randint(0, 100) for i in range(0, 11)}
print(listok5)
