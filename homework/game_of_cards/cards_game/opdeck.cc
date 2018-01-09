#include "opdeck.hh"

void OperationDeck::deck() {
	std::cout << "opdeck.hh";
	std::string arr[games_.size()];
	for (int i = 0; i < games_.size() - 1; ++i)
	{
		arr[i] = games_.pop();
	}
	games_.push(execute(&arr));
};
