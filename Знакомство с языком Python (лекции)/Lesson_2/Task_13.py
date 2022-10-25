list1 = [1, 2, 3, 4, 5]
list2 = list1

for e in list1:
    print(e)

print()

for e in list2:
    print(e)

list1[0] = 123
list2[1] = 333

for e in list1:
    print(e)

print()

for e in list2:
    print(e)

print()

print(list1)
print(list1.pop())
print(list1)
print(len(list1))

print()

print(list1)
print(list1.insert(2, 11))
print(list1)
print(len(list1))

print()

print(list1)
print(list1.append(11))
print(list1)
print(len(list1))
