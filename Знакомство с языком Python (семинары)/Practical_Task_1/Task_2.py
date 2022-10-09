"""
Напишите программу для проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z
для всех значений предикат.
"""

res = True
if res:
    for X in range(2):
        if res:
            for Y in range(2):
                if res:
                    for Z in range(2):
                        if (not (X or Y or Z)) == (not X and not Y and not Z):
                            res = True
                        else:
                            res = False
                            break

print('Утверждение: ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z - ', end='')
print('истинно для всех значений предикатов' if res else 'ложно')
