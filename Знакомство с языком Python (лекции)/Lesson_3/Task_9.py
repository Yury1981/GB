with open(f'file.txt', 'r') as f:
    user_str = f.read() + ' '
print(user_str)

spis = []

while user_str != '':
    space_pos = user_str.index(' ')
    spis.append(int(user_str[:space_pos]))
    user_str = user_str[space_pos + 1:]
print(spis)

out = []
for e in spis:
    if not e % 2:
        out.append((e, e ** 2))

print(out)
