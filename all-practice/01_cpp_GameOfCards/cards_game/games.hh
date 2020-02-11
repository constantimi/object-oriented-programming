#ifndef GAMES_HH__
#define GAMES_HH__


#include <vector>
#include <string>
#include <iostream>

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


#endif
