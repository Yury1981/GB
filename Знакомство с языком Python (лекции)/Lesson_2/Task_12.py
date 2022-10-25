a = {1, 2, 3, 5, 8}
print(a)
b = {2, 5, 8, 13, 21}
print(b)
c = a.copy()
print(c)
u = a.union(b)
print(u)
i = a.intersection(b)
print(i)
dl = a.difference(b)
print(dl)
dr = b.difference(a)
print(dr)
q = a \
    .union(b) \
    .difference(a.intersection(b))
print(q)

s = frozenset(a)
print(s)
