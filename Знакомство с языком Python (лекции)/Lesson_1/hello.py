print('Hello world')
value = None
print(type(value))
a = 123
b = 1.23
print(type(a))
print(type(b))
value = 12345
print(type(value))
s = "'hello \'world'"
print(s) # Вывод строки
print(a, b, s)
print('{2} - {1} - {0}'.format(a, b, s))
print(f'{a} - {b} - {s}')
f = True
print(f)
list = [1, 2, 3]
print(list)
col = ['hello', 1,2,3,4.5,True]
print(col)
print(a, " + ", b, " = ", a + b)
print('введите a')
a = int(input())
print(a)

a = 1 < 4
print(a)
a = 1 < 4 and 5 > 2

a = int(input("a = "))
b = int(input("b = "))
if a > b:
    print(a)
else:
    print(b)
