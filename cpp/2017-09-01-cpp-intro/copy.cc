#include <iostream>
using namespace std;


int main() {

	char ch;
	
	while(true) {
		cin.get(ch);

		if(!cin.good()) {
			break;
		}

		cout << ch << endl;
	}

	return 0;
}

