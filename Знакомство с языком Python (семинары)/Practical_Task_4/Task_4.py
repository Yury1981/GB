""""
Задана натуральная степень k.
Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена
и записать в файл многочлен степени k.
Пример:
- k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0
"""

import random


def create_kof(x):
    spis = []
    for i in range(x + 1):
        spis.append(random.randint(0, 100))
    while spis[0] == 0:
        spis[0] = random.randint(0, 100)
    return spis


def create_mn(x):
    y = ''
    for i in range(len(x)):
        if i < len(x) - 2:
            if x[i] > 0:
                if x[i] != 1:
                    y += f'{x[i]}*x^{len(x) - i - 1}'
                else:
                    y += f'x^{len(x) - i - 1}'
            if x[i + 1] != 0:
                y += ' + '
        elif i == len(x) - 2:
            if x[i] != 0 and x[i] > 1:
                y += f'{x[i]}*x'
            elif x[i] != 0:
                y += 'x'
            if x[i + 1] != 0:
                y += ' + '
        elif i == len(x) - 1:
            if x[i] != 0:
                y += f'{x[i]} = 0'
            else:
                y += ' =0'

    return y


def write_file(x):
    with open('file1.txt', 'w') as f:
        f.write(x)


k = input('Введите степень k: ')
while not k.isdigit() or k == '0':
    k = input('Введите степень k: ')
k = int(k)

ur = create_mn(create_kof(k))
print(ur)
write_file(ur)
