#include <iostream>
#include <vector>
#include <string>
#include <iostream>
#include <list>
#include <sstream>

using namespace std;

class Deck;

class OperationError {};

class Operation{
	std::vector<Operation*> operations_;
	std::vector<std::string> stack_;
public:
	Operation();

	void add_operation(Deck* op);
	Deck* get_operation(const string& name);
	void push(string val);
	int size() const;
	bool empty() const;
	std::string pop();

};

class Deck{
	string name_;
protected:
	Operation& games_;
public:
		Deck(Operation& games, const std::string& name)
		: games_(games), name_(name){}

		const std::string& get_name() const {
			return name_;
		}

};

Operation::Operation() {}

void Operation::add_operation(Deck* op) {
	Deck* check = get_operation(op->get_name());
	if(check!=0) {
		cout << "operation " << op->get_name() 
			<< " already added..." << endl;
	} else {
		operations_.push_back(op);
	}
}

Deck* Operation::get_operation(const string& name) {
	for(vector<Operation*>::iterator it = operations_.begin();
		it!=operations_.end(); ++it) {
	
		if(name == (*it)->get_name()) {
			return *it;
		}	
	}
	return 0;
}


bool Operation::empty() const {
	return stack_.empty();
}

int Operation::size() const {
	return stack_.size();
}

void Operation::push(string val) {
	stack_.push_back(val);
}

string Operation::pop() {
	if(stack_.empty()) {
		throw OperationError();
	}
	string val = stack_.back();
	stack_.pop_back();
	return val;
}



int main(int argc, char const *argv[])
{
	string token;
	
	while(1) {
			//getline();
				
	}
	return 0;
}