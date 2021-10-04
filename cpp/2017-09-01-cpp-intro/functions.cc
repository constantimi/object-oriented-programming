#include <iostream>
using namespace std;

#define SIZE_MAX 5

void fun(int& value) {
	cout << "val=" << value << endl;
	value = 42;
	cout << "val new value=" << value << endl;
}

int getMin(int numbers[])
{
    int min = numbers[0];
    for (int i = 1; i < SIZE_MAX; i++)
    {
        if(min > numbers[i])
        {
            min = numbers[i];
        }
    }
    return min;
}

int getMax(int numbers[])
{
    int max = numbers[0];
    for (int i = 1; i < SIZE_MAX; i++)
    {
        if(max < numbers[i])
        {
            max = numbers[i];
        }
    }
    return max;
}

void getMinAndMax(int numbers[], int* min, int* max)
{
    for (int i = 0; i < SIZE_MAX; i++)
    {
        if(numbers[i] > *max)
        {
            *max = numbers[i];
        }

        if(numbers[i] < *min)
        {
            *min = numbers[i];
        }
    }
    
}

int main(int argc, char const *argv[])
{
    int value = 2;
    fun(value);

    int numbers[SIZE_MAX];

    for(int i = 0; i < SIZE_MAX; i++)
    {
        cin >> numbers[i];
        cout << numbers[i] << endl;
    }

    cout << "Min is " << getMin(numbers) << endl;
    cout << "Max is " << getMax(numbers) << endl;

    int min = numbers[0];
    int max = numbers[0];
    getMinAndMax(numbers, &min, &max);
    cout << "Min is " << min << endl;
    cout << "Max is " << max << endl;
    
    return 0;
}