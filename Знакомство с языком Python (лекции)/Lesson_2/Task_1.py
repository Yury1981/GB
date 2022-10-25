colors = ['red', 'green', 'blue']
data = open('file.txt', 'a')
data.writelines(colors)  # Разделителей не будет
data.write('\nLINE 2\n')
data.write('LINE 3\n')
data.close()
