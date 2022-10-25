t = ()
print(type(t))
t = (1,)
print(type(t))
t = (1)
print(type(t))
t = (28, 9, 1990)
print(type(t))
colors = ['red', 'green', 'blue']
print(colors)
t = tuple(colors)
print(t)
print(t[0])
print(t[2])
print(t[-2])

for e in t:
    print(e)
