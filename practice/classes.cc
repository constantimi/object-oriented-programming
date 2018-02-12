#include <iostream>

using namespace std;

class Increment {
	int count_ ;
	const int step_;
public:
	Increment(int c = 0, int s = 1)
	: count_(c), step_(s){}

	void step() {
		count_ += step_;
	}

	void print() const {
		cout << "count: " << count_ << ", step: " << step_ << endl;
	}
};

int main() {
	Increment counter(7,7);
	for (int i = 0; i < 5; ++i)
	{
		counter.step();
		cout << "i = " << i  << ", ";
		counter.print();
	}
	return 0;
}