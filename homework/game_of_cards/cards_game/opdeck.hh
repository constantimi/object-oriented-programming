#ifndef OPDECK_HH_
#define OPDECK_HH_

#include <string>
#include "operation.hh"
#include "games.hh"

class OperationDeck : public Operation{

public:
	OperationDeck(Games& game, const std::string& name) : Operation(game, name){}

	void deck();

protected:
	virtual std::string execute(std::string &) const = 0;

};

#endif