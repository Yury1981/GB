""""
Даны два файла, в каждом из которых находится запись многочлена.
Задача - сформировать файл, содержащий сумму многочленов.
"""


def read_file(x):
    with open(f'file{x}.txt', 'r') as fr:
        res = fr.readline()
    return res


def find_kof(ur):
    ur = ur.replace(' = 0', '')
    ur = ur.split(' + ')
    res = []
    for i in range(len(ur)):
        el = ''
        for k in range(len(ur[i])):
            if ur[i][k] != 'x':
                if ur[i][k].isdigit():
                    el += ur[i][k]
            else:
                break
        el = int(el)
        res.append(el)
    for i in range(len(ur)):
        if ur[i] == '*':
            ur[i] = '1'
    return res


def summa(x, y):
    if len(x) < len(y):
        m = x
        x = y
        y = m
    res = []
    for i in range(len(x)):
        res.append(x[i] + y[i])
    return res


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
    with open('file3.txt', 'w') as fw:
        fw.write(x)


with open(f'file1.txt', 'r') as f:
    ur1 = f.readline()
with open(f'file2.txt', 'r') as f:
    ur2 = f.readline()

print(ur1)
print(ur2)

ur3 = create_mn(summa(find_kof(ur1), find_kof(ur2)))
print(ur3)
write_file(ur3)



