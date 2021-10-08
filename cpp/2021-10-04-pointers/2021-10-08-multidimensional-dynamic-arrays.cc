/// This functionality represents a dynamic pointers 
/// **table has pointers localizing arrays in other words
/// *rows -> cols 

#include <iostream>
using namespace std;

int main(int argc, char* argv[])
{
    int rows, cols;
    cout << "rows, cols:";
    cin >> rows >> cols;

    int** table = new int*[rows];
    for (int i = 0; i < rows; i++)
    {
        table[i] = new int[cols];
    }

    table[1][2] = 88;

    // Deallocate memory
    for (int i = 0; i < rows; i++)
    {
        delete[] table[i];
    }

    // Delete the content
    delete[] table;

    // Set the pointer to NULL
    table = NULL;

    // Wait till hitting enter, so you can see the output
    system("pause>0");

    return 0;
}