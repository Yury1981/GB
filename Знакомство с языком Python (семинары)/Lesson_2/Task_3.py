"""
Напишите программу, в которой пользователь будет задавать две строки, а программа - определять количество вхождений одной строки в другой.
Пример:
"hello or world", "or" -> 2
"""

str_1 = input('Введите 1-ю строку: ')
str_2 = input('Введите 2-ю строку: ')
count = 0

if len(str_1) < len(str_2):
    temp = str_1
    str_1 = str_2
    str_2 = temp


def find(x, y, i):
    for k in range(len(y)):
        if x[i + k] != y[k]:
            return 0
    return 1


for i in range(len(str_1) - len(str_2) + 1):
    if str_1[i] == str_2[0]:
        count += find(str_1, str_2, i)

print(f'{str_2} встречается в строке {str_1}', count, 'раза.')





# str = input("Введите строку: ")
# substr = input("Введите подстроку: ")
#
# found_cnt = 0
#
# for i in range(len(str) - len(substr) + 1):
#     if str[i : i + len(substr)] == substr:
#         found_cnt += 1
#
# print(found_cnt)

# text = "hello or world"
# find = "or"
#
# count = 0
# for _i in range(0, len(text), len(find)):
#     if text[_i:_i + len(find)] == find:
#         count += 1
# print(f'"{text}", "{find}" -> {count}')
