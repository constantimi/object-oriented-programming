#!/bin/python3


def areConsecutive(arr, n):
    # 1) Get the minimum element in array
    min = arr[0]

    # 2) Get the maximum element in array
    max = arr[1]

    # 3) max - min + 1 is equal to n
    # then only check all elements
    if (max - min + 1 == n or min - max + 1 == n):
        # If we do not see a negative value
        # then all elements are distinct
        return True

    return False  # if (max - min + 1 != n)


def main():
    # To store number of tast cases
    index = int(input("Please input count of your numbers:"))
    # To store input here
    li = []

    for _ in range(index):
        x = int(input())
        li.append(x)

    li.sort()

    for i in range(len(li)):
        arr = []

        arr.append(li[0])
        arr.append(li[1])

        if (areConsecutive(arr, 2)):
            print("[{}, {}] with consecutive count of 2".format(li[i], li[i + 1]))
        else:

            print("[{}, {}] with consecutive count of 1".format(li[i], li[i]))


if __name__ == '__main__':
    main()
