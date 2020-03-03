def max_num(num1, num2, num3):
    if num1 >= num2 and num1 >= num3:
        return num1
    elif num2 >= num1 and num2 >= num3:
        return num2
    else:
        return num3


def compate(str1, str2):
    if str1 == str2:
        return True
    elif str1 != str2:
        return False


print(max(300, 453, 99))
print(compate("dog", "dog"))
