#include <sstream>
#include <iostream>
using namespace std;

int main(){
    string line = "C10 H7 DA CJ SA SJ CQ H10 S10 CA D7 D9 D8 HQ CK S8 S9 HJ D10 SQ H8 DQ H9 DK DJ HA S7 C8 SK C7 HK";
    string arr[4];
    int i = 0;
    stringstream ssin(line);
    while (ssin.good() && i < 4){
        ssin >> arr[i];
        ++i;
    }
    for(i = 0; i < 4; i++){
        cout << arr[i] << endl;
    }
}