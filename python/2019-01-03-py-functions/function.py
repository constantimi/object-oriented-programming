def name_of_the_method(parameter):
    print("Inside the function must be indented.")
    print("Show the parameter: " + parameter)


print("Top")
name_of_the_method("Any type of data")
print("Bottom")


def cube(num):
    return num * num * num


print("What is cube of 3?")
print(cube(3))

is_male = True
is_tall = True
is_your_eyes_blue = True

if is_male or is_tall:
    print('You are a male or tall or both.')
    if is_your_eyes_blue:
        print('Your eyes are blue.')
elif is_male and not (is_tall):
    print('You are a short male.')
elif not (is_male) and is_tall:
    print('You are not male, but you are tall.')
else:
    print('You are neither a male or tall.')
