
lucky_numbers = [4, 8, 15, 16, 23, 42]
friends = ["Kevin", "Karen", "Jim", "Oscar", "Toby",  3, True]

friends[1] = "Mike"
print(friends[1])
print(friends[0:5])

print(friends.remove("Oscar"))

friends.extend(lucky_numbers)
print(friends)

friends.append("Creed")
print(friends)

friends.insert(1, "Kelly")
print(friends)

friends.remove(3)
print(friends)

friends.pop()
print(friends)

friends.clear()
print(friends)

lucky_numbers.sort()
print(lucky_numbers)

lucky_numbers.reverse()
print(lucky_numbers)


