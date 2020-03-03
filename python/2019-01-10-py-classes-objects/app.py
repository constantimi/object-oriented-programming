from Student import Student

student1 = Student("Peter", "Business", 3.1, False)
student2 = Student("Pam", "Art", 5.6, False)

print("name: " + student1.name + " major:" + student1.major)
print("name: " + student2.name + " major:" + student2.major)

print(student2.on_honor_roll())
