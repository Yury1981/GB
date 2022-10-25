"""
Задайте список из N элементов, заполненных числами из промежутка [-N, N].
Найдите произведение элементов на указанных позициях.
Позиции хранятся в файле file1.txt в одной строке одно число.
"""


def create(x):
    s = []
    for i in range(-x, x + 1):
        s.append(i)
    return s


def composition(s):
    f = open('file.txt', 'r')
    x = [line.strip() for line in f]
    print(f'Pos: {x}')
    c = 1
    for i in range(len(x)):
        y = int(x[i])
        c *= s[y]
    f.close()
    return c


N = input('Введите N: ')
while not N.isdigit():
    N = input('Введите N: ')
N = int(N)

print('Список: ', create(N))
print('Произведение = ', composition(create(N)))
