employee_file = open("employees.txt", "w")
# employee_file = open("employees.txt", "r")
# employee_file = open("employees.txt", "a")
# employee_file = open("index.html", "w")

employee_file.write("\nToby - Human Resources")

# for employee in employee_file.readlines():
#     print(employee)

# print(employee_file.readable())
# print(employee_file.readlines())
# print(employee_file.readline())

employee_file.close()
