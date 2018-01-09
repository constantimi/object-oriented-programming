#ifndef LITERAL_HH__
#define LITERAL_HH__

#include "operation.hh"
#include <string>

class Literal: public Operation {
	std::string val_;
public:
	Literal(Games& game, std::string val);
};

#endif
