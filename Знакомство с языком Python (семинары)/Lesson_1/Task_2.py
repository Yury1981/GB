"""
Напишите программу, которая на вход принимает 5 чисел и находит максимальное из них.
Примеры:
1,4,8,7,5 -> 8
78,55,36,90,2 -> 90"""

import random

nums = []
for i in range(5):
    a = random.randint(1, 100)
    nums.append(a)

maximum = nums[0]

for i in range(1, len(nums)):
    if nums[i] > maximum:
        maximum = nums[i]

print(nums)
print('Максимальное число: ', + maximum)

input('Нажмите Enter для завершения')
