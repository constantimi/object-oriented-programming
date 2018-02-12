#include <iostream>

using namespace std;

class DeepThought {
public:
	static int ANSWER;
	static void find_the_answer(void);
};

int DeepThought::ANSWER = -1;
void DeepThought::find_the_answer(void){
	ANSWER = 42;
}

int main(void){
	DeepThought::find_the_answer();
	cout << "The answer is: " 
	     << DeepThought::ANSWER << endl;
 return 0;
}