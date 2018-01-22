#ifndef OPERATION_HH_
#define OPERATION_HH_

#include <string>
#include "games.hh"

class Operation {
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

#endif