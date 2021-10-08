#include <iostream>
#include <vector>
using namespace std;

int add(int a, int b)
{
    return a + b;
}

bool ascendingCompare(int a, int b)
{
    return a < b;
}

bool descendingCompare(int a, int b)
{
    return a > b;
}

void sortAscending(vector<int>& numbersVector)
{
    for (int startIndex = 0; startIndex < numbersVector.size(); startIndex++)
    {
        int bestIndex = startIndex;
        for (int currentIndex = startIndex + 1; currentIndex < numbersVector.size(); currentIndex++)
        {
            if (ascendingCompare(numbersVector[currentIndex], numbersVector[bestIndex]))
            {
                bestIndex = currentIndex;
            }
        }

        swap(numbersVector[startIndex], numbersVector[bestIndex]);
        }
    
}

void sortDescending(vector<int>& numbersVector)
{
    for (int startIndex = 0; startIndex < numbersVector.size(); startIndex++)
    {
        int bestIndex = startIndex;
        for (int currentIndex = startIndex + 1; currentIndex < numbersVector.size(); currentIndex++)
        {
            if (descendingCompare(numbersVector[currentIndex], numbersVector[bestIndex]))
            {
                bestIndex = currentIndex;
            }
        }

        swap(numbersVector[startIndex], numbersVector[bestIndex]);
        }
}

void customSort(vector<int>& numbersVector,bool(*compareFuncPtr)(int, int))
{
    for (int startIndex = 0; startIndex < numbersVector.size(); startIndex++)
    {
        int bestIndex = startIndex;
        for (int currentIndex = startIndex + 1; currentIndex < numbersVector.size(); currentIndex++)
        {
            if (compareFuncPtr(numbersVector[currentIndex], numbersVector[bestIndex]))
            {
                bestIndex = currentIndex;
            }
        }

        swap(numbersVector[startIndex], numbersVector[bestIndex]);
        }
}

void printNumbers(vector<int>& numbersVector)
{
    for (int i = 0; i < numbersVector.size(); i++)
    {
        cout << numbersVector[i] << ' ';
    }
    
}

int main()
{
    // Function Pointer Example
    int (*funcPtr)(int, int) = add;
    cout << add(2, 3) << endl;
    cout << funcPtr(3, 4) << endl;

    vector<int> myNumbers = {2, 5, 3, 6, 1, 4};
    // sortAscending(myNumbers);
    bool(*funcPtrCompare)(int, int) = ascendingCompare;
    customSort(myNumbers, funcPtrCompare);
    printNumbers(myNumbers);
}