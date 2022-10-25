"""
Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
Пример:
- 6782 -> 23
- 0,56 -> 11
"""


def control(b):
    count = 0
    for k in range(len(b)):
        if (b[k].isdigit() or b[k] == '.' or b[k] == ',' or b[k] == '-') and count <= 1:
            if b[k] == '.' or b[k] == ',' or b[k] == '-':
                count += 1
            continue
        else:
            return False
    return True


a = input('Введите вещественное число: ')
while a.isdigit():
    # while not control(a):
    a = input('Введите вещественное число: ')
res = 0

for i in range(len(a)):
    if a[i].isdigit():
        x = int(a[i])
        res += x

print(f'Сумма цифр равна: {res}')
