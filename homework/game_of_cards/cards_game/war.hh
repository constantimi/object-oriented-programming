#ifndef WAR_HH_
#define WAR_HH_

#include "opdeck.hh"


class WAR : public OperationDeck{

public:
	WAR(Games& games)
	: OperationDeck(games, "WAR"){}
	
	std::string execute(std::string &arr);	
};
#endif