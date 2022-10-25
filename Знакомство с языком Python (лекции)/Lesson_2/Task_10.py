dictionary = {}
dictionary = \
    {
        'up': 'вверх',
        'left': 'влево',
        'down': 'вниз',
        'right': 'вправо'
    }
print(dictionary)
print(dictionary['left'])

for k in dictionary.keys():
    print(k)

for k in dictionary.values():
    print(k)

for k in dictionary:
    print('{}: {}' .format(k, dictionary[k]))
    