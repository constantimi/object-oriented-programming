#include "composite.hh"

#include <list>
#include <string>
using namespace std;

Composite::Composite(Games& game, const string& name)
: Operation(game, name)
{}

void Composite::add_child(Operation* op) {
	children_.push_back(op);
}

void Composite::deck(){
	for (list<Operation*>::iterator it = children_.begin(); it != children_.end(); ++i){
		(*it) -> deck_operation();
	}
}

