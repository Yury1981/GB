def new_string(symbol, count=3):
    return symbol * count


print(new_string('!', 5))  # !!!!!!
print(new_string('!'))  # TypeError missing 1 required ...
print(new_string(4))  # 12
