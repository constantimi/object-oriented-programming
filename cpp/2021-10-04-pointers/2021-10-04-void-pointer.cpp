#include <iostream>
using namespace std;

void printNumber(int* numberPtr){
    cout<< "Your number:" << *numberPtr << endl;
}

void printLetter(char* charPtr){
    cout<< "Your char:" << *charPtr << endl;
}

void printVoidPointer(void* ptr, char type){
    switch (type)
    {
    case 'i': 
        cout<< *(int*)ptr << endl;
        break; 
    case 'c':
        cout<< *(char*)ptr << endl;
        break;
    default:
        break;
    }
}

int main(int argc, char const *argv[])
{
    // Pointers
    int number = 5;
    char letter = 'a';

    cout<< "Pointers" << endl;
    cout<< "------------" << endl;
    printNumber(&number);
    printLetter(&letter);
    printVoidPointer(&number,'i');

    //Arrays
    cout<< "Arrays" << endl;
    cout<< "------------" << endl;
    int luckyNumbers[5] = {2,3,5,7,9};
    cout<< luckyNumbers << endl;
    cout<< &luckyNumbers[0] << endl;
    cout<< luckyNumbers[2] << endl;
    cout<<*(luckyNumbers + 2) << endl;

    
    return 0;
}
