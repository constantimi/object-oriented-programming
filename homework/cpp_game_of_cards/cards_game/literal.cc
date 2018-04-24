#include "literal.hh"
#include "games.hh"


Literal::Literal(Games& calc, std::string val)
: Operation(game, "#LITERAL#"), val_(val)
{}

void Literal::deck() {
	Games_.push(val_);
}