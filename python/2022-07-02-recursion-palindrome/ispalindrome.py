def isPalindrome(input):
    # Define the base-case / stopping condition
    if len(input) == 0 or len(input) == 1:
        return True
    
    # Do some work to shrink the problem space
    if input[0] == input[-1]:
       return isPalindrome(input[1:-1])
    
    # Additional base-case to handle non-palindromes
    return False

def main():
    # Input string
    str = input("Enter your palindrome: ")

    # Base check
    print(isPalindrome(str))

if __name__ == '__main__':
    main()
