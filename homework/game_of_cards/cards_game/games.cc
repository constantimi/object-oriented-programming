#include "operation.hh"
#include "games.hh"
#include "composite.hh"
#include "literal.hh"

#include <string>
#include <vector>
#include <sstream>

using namespace std;


Games::Games() {}

void Games::add_operation(Operation* op) {
	Operation* check = get_operation(op->get_name());
	if(check!=0) {
		cout << "operation " << op->get_name() 
			<< " already added..." << endl;
	} else {
		operations_.push_back(op);
	}
}

Operation* Games::get_operation(const string& name) {
	for(vector<Operation*>::iterator it = operations_.begin();
		it!=operations_.end(); ++it) {
	
		if(name == (*it)->get_name()) {
			return *it;
		}	
	}
	return 0;
}


bool Games::empty() const {
	return stack_.empty();
}

int Games::size() const {
	return stack_.size();
}

void Games::push(string val) {
	stack_.push_back(val);
}

string Games::pop() {
	if(stack_.empty()) {
		throw GamesError();
	}
	string val = stack_.back();
	stack_.pop_back();
	return val;
}


void Games::run(istream& in, ostream& out) {
	string token;
	
	while(token != "quit") {
		out << ">";
		in >> token;
		if(! in.good()) {
			break;
		}	
			Operation* op = get_operation(token);
			if(op!=0) {
				op->deck();
				//out << stack_.back() << endl;
			} else {
				istringstream istr(token);

					string val;
					istr >> val;
					if(!istr.fail()) {
						cout << "pushed" << endl;
						push(val);
					} else {
						cerr << "ERROR: Unknown operation" << token << endl;
					}
				
			}
				
	}

}