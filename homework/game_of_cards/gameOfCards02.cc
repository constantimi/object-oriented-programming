#include <iostream>
#include <vector>
#include <string>
#include <iostream>
#include <list>
#include <sstream>

using namespace std;

class Operation;


class GamesError {};

class Games {
	std::vector<Operation*> operations_;
	std::vector<std::string> stack_;
	
public:
	Games();

	void add_operation(Operation* op);
	Operation* get_operation(const std::string& name);
	
	void push(std::string val);
	int size() const;
	bool empty() const;
	std::string pop();
	
	void run(std::istream& in, std::ostream& out);

};

class Operation{
	std::string name_;
protected:
	Games& games_;
public:
		Operation(Games& games, const std::string& name)
		: games_(games), name_(name){}

		const std::string& get_name() const {
			return name_;
		}

		virtual void deck() = 0;
};


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
	
	while(1) {
			out << ">";		
			in >> token;
			if(token == "quit")break;
			if(! in.good())break;

				Operation* op = get_operation(token);
				if(op!=0) {
					op->deck();
					if("-1" == stack_.back()){
						stack_.pop_back();
						cout << "ERROR: Not enough cards for " << token << endl; 
					}
				} else {
						string val;
							
						istringstream str(token);
						
							if(! str.fail()) {
								//cout << "pushed" << endl;
								push(val);
							} else {
								cerr << "ERROR: Unknown operation" << token << endl;
							}				
				}		
				
	}

}

class ExecuteDeck : public Operation{

	public:
		ExecuteDeck(Games& game, const std::string& name) : Operation(game, name){}

		void deck(); 
	protected:
		virtual int execute(std::vector<std::string> );
		virtual std::string execute(std::vector<std::string> );
};

void ExecuteDeck::deck() {
	std::vector<std::string> result_;

	for (int i = 0; i < games_.size(); ++i)
	{
		string r = games_.pop_back();
		result_.push(r);
	}
	cout << execute(result_);

};

class Size : public ExecuteDeck{
	public:
		Size(Games& games):
		ExecuteDeck(games, "size"){}

		int execute(std::vector<std::string> ) const = 0;
};

class Size::execute( std::vector<std::string> s_){
	return s_.size();
}

class CreateDeck : public Operation{

public:
	CreateDeck(Games& game, const std::string& name) : Operation(game, name){}

	void deck();

protected:
	virtual int execute(int size) = 0;

};

void CreateDeck::deck() {
	
	if(!execute(games_.size())){
		games_.push("-1");
	}
};

class WAR : public CreateDeck{

public:
	WAR(Games& games)
	: CreateDeck(games, "War"){}
	
	int execute(int size);	
};

int WAR::execute( int size){
	return size == 52;
}

class Belote : public CreateDeck{

public:
	Belote(Games& games)
	: CreateDeck(games, "Belote"){}
	
	int execute(int size);	
};

int Belote::execute( int size){
	return size == 32;
}

class Santase : public CreateDeck{

public:
	Santase(Games& games)
	: CreateDeck(games, "Santase"){}
	
	int execute(int size);	
};

int Santase::execute( int size){
	return size == 32;
}
class Composite: public Operation {
	std::list<Operation*> children_;

public:
	Composite(Games& calculator, const std::string& name);
	
	void add_child(Operation* op);

	void deck();
};

Composite::Composite(Games& game, const string& name)
: Operation(game, name)
{}

void Composite::add_child(Operation* op) {
	children_.push_back(op);
}

void Composite::deck(){
	for (list<Operation*>::iterator it = children_.begin(); it != children_.end(); ++it){
		(*it) -> deck();
	}
}

int main(){
	Games games;
	games.add_operation(new WAR(games));
	games.add_operation(new Santase(games));
	games.add_operation(new Belote(games));
	
	games.run(cin, cout);
}