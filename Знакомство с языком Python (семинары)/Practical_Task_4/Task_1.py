""""
Вычислить число c заданной точностью d
Пример:
- при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$
"""


def pi_val():
    n = 1
    res = 0
    for i in range(1000000):
        if i % 2 == 0:
            res += 4 / n
        else:
            res -= 4 / n
        n += 2
    return res


def sharp(x):
    x *= 10
    if x >= 1:
        return 1
    else:
        n = 1
        return n + sharp(x)


def res_round(x):
    y = pi_val()
    res = y * 10 ** sharp(x)
    res //= 1
    res /= 10 ** sharp(x)
    return res


d = float(input("Задйте точность. (0. ... 1): "))
print(res_round(d))
