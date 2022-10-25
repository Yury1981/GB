"""
Задайте список. Напишите программу, которая определит, присутствует ли в заданном списке строк некое число.
Пример:
["qwe", "asd", "12", "qwe", "2"], 2 -> True
["qwe", "asd", "qwe", "681"], 7 -> False
["qwe", "asd", "qwe", "0"], 0 -> True
"""


def find(x, spis):
    for i in spis:
        if i == x:
            return True
    return False


user_list = ["qwe", "asd", "12", "qwe", "2", "qwe", "asd", "qwe", "681", "qwe", "asd", "qwe", "0", "54", "yyy"]

num = input('Введите число для поиска: ')
print(find(num, user_list))
