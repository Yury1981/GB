"""
Напишите программу, удаляющую из текста все слова, содержащие "абв".


test_data = [
    [["привет абв как абвышные дела?", "абв"], "привет как дела?"]
]
for args, exp in test_data:
    assert remove_substr(*args) == exp
    #assert remove_substr_func(*args) == exp

"""