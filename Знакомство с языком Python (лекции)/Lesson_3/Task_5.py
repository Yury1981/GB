# def summa(x, y):
#     return x + y


# f = summa
summa = lambda x, y: x + y + 1


def mult(x, y):
    return x * y


def calc(op, a, b):
    print(op(a, b))
    return op(a, b)


calc(mult, 4, 5)
calc(summa, 4, 5)
