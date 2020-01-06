#include <iostream>
#include <sstream>
#include <string>
#include <list>
#include <vector>
#include <algorithm>

using namespace std;

class Exception {
	string error_;
public:
	Exception(string error_message)
		: error_(error_message) 
	{}

	void get_message() {
		cout << error_;
	}
};

class Deck;

class Operation {
	string name_;

protected:
	Deck& deck_;

public:
	Operation(Deck& deck, string name)
		: deck_(deck), name_(name) {}

	string get_name() const {
		return name_;
	}
	
	virtual void execute() = 0;
};

class Deck {
	vector<string> started_cards_;
	vector<string> cards_in_deck_;
	vector<Operation*> operations_;
	bool status_ = false;

	vector<char> suits_ = {'C', 'D', 'H', 'S'};
	vector<string> ranks_;
	int needed_cards_;
	int cards_in_hand_;

public:
	void add_operation(Operation* operation) {
		operations_.push_back(operation);
	}

	Operation* find_operation(string name) {
		for (vector<Operation*>::iterator it = operations_.begin(); it != operations_.end(); ++it) {
			if ((*it) -> get_name() == name) {
				return *it;
			}
		}
		throw Exception("ERROR: Unknown operation");
	}

	bool get_status() const {
		return status_;
	}

	void set_status(bool status) {
		status_ = status;
	}

	// setter/getter of starting cards and getter of theirs count
	void set_started_cards(vector<string> cards) {
		started_cards_ = cards;
	}

	vector<string> get_started_cards() const {
		return started_cards_;
	}

	int started_cards_size() const {
		return started_cards_.size();
	}

	// setter/getter of cards in deck and getter of theirs count
	void set_deck(vector<string> cards) {
		cards_in_deck_ = cards;
	}

	vector<string> get_deck() const {
		return cards_in_deck_;
	}

	int deck_size() const {
		return cards_in_deck_.size();
	}

	// getter for card from begin/end in deck
	string front() const {
		if(deck_size() == 0) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		return cards_in_deck_.front();
	}

	string back() const {
		if(deck_size() == 0) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		return cards_in_deck_.back();
	}

	// pop cards from begin/end
	string pop_front() {
		if(deck_size() == 0) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		string card = front();
		cards_in_deck_.erase(cards_in_deck_.begin());
		return card;
	}

	string pop_back() {
		if(deck_size() == 0) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		string card = back();
		cards_in_deck_.pop_back();
		return card;
	}

	//setter/getter for suits
	void set_suits(vector<char> suits) {
		suits_ = suits;
	}

	vector<char> get_suits() {
		return suits_;
	}

	//setter/getter for ranks
	void set_ranks(vector<string> ranks) {
		ranks_ = ranks;
	}

	vector<string> get_ranks() {
		return ranks_;
	}
	
	// setter/getter for count of needed cards
	void set_needed_cards(int needed_cards) {
		needed_cards_ = needed_cards;
	}

	int get_needed_cards() {
		return needed_cards_;
	}

	// setter/getter for count of a hand
	void set_hand_count(int cards_in_hand) {
		cards_in_hand_ = cards_in_hand;
	}

	int get_hand_count() {
		return cards_in_hand_;
	}
};

class CreateDeckOperation : public Operation {
protected:
	virtual void create() = 0;

public:
	CreateDeckOperation(Deck& deck, string name)
		: Operation(deck, name) {}

	void execute() {
		create();
		vector<string> cards;
		vector<string> starting_cards = deck_.get_started_cards();

		vector<char> suits = deck_.get_suits();
		vector<string> ranks = deck_.get_ranks();

		for (int i  = 0; i < starting_cards.size() && cards.size() < deck_.get_needed_cards(); i++) {
			int next = 1;
			for (int j = 0; j < suits.size(); j++) {
				if(starting_cards[i].find(suits[j]) != string::npos) {
					next = 0;
					break;
				}
			}
			if(next) continue;

			for(int j = 0; j < ranks.size(); j++) {
				if(starting_cards[i].find(ranks[j]) != string::npos) {
					cards.push_back(starting_cards[i]);
					break;
				}
			}
		}

		if (cards.size() < deck_.get_needed_cards()) {
			throw Exception("ERROR: Not enough cards for " + get_name());
		}

		deck_.set_deck(cards);
		deck_.set_status(true);
	}
};

class ExecutableOperation : public Operation {
protected:
	virtual void run() = 0;

public:
	ExecutableOperation(Deck& deck, string name)
		: Operation(deck, name) {}
	
	virtual void execute() {
		if(!deck_.get_status()) {
			throw Exception("ERROR: No deck");
		}
		run();
		cout << endl;
	}
};

class War : public CreateDeckOperation {
public:
	War(Deck& deck)
		: CreateDeckOperation(deck, "War") {}

protected:
	void create() {
		deck_.set_ranks(vector<string> {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"});
		deck_.set_needed_cards(52);
		deck_.set_hand_count(26);
	}
};

class Belote : public CreateDeckOperation {
public:
	Belote(Deck& deck)
		: CreateDeckOperation(deck, "Belote") {}

protected:
	void create() {
		deck_.set_ranks(vector<string> {});
		deck_.set_needed_cards(32);
		deck_.set_hand_count(8);
	}
};

class Santase : public CreateDeckOperation {
public:
	Santase(Deck& deck)
		: CreateDeckOperation(deck, "Santase") {}

protected:
	void create() {
		deck_.set_ranks(vector<string> {"9", "J", "Q", "K", "10", "A"});
		deck_.set_needed_cards(24);
		deck_.set_hand_count(6);
	}
};

class Size : public ExecutableOperation {
public:
	Size(Deck& deck)
		: ExecutableOperation(deck, "size") {}

protected:
	void run() {
		cout << deck_.deck_size();
	}
};

class TopCard : public ExecutableOperation {
public:
	TopCard(Deck& deck, string name = "top_card")
		: ExecutableOperation(deck, name) {}

protected:
	void run() {
		if(deck_.deck_size() < 1) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		cout << deck_.front();
	}
};

class DrawTopCard : public ExecutableOperation {
public:
	DrawTopCard(Deck& deck)
		: ExecutableOperation(deck, "draw_top_card") {}
	
protected:
	void run() {
		if(deck_.deck_size() < 1) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		cout << deck_.pop_front();
	}
};

class BottomCard : public ExecutableOperation {
public:
	BottomCard(Deck& deck, string name = "bottom_card")
		: ExecutableOperation(deck, name) {}

protected:
	void run() {
		if(deck_.deck_size() < 1) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		cout << deck_.back();
	}
};

class DrawBottomCard : public ExecutableOperation {
public:
	DrawBottomCard(Deck& deck)
		: ExecutableOperation(deck, "draw_bottom_card") {}

protected:
	void run() {
		if(deck_.deck_size() < 1) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		cout << deck_.pop_back();
	}
};

class Shuffle : public ExecutableOperation {
public:
	Shuffle(Deck& deck)
		: ExecutableOperation(deck, "shuffle") {}

protected:
	void run() {
		vector<string> deck = deck_.get_deck();
		random_shuffle(deck.begin(), deck.end());
		
		for(int i = 0; i < deck.size(); i++) {
			cout << deck[i] << ' ';
		}

		deck_.set_deck(deck);
	}
};

class Sort : public ExecutableOperation {
public:
	Sort(Deck& deck)
		: ExecutableOperation(deck, "sort") {}

protected:
	void run() {
		vector<string> deck = deck_.get_deck();
		vector<char> suits = deck_.get_suits();
		vector<string> ranks = deck_.get_ranks();

		int sorted = 0;
		while(!sorted) {
			sorted = 1;
			for(int i = 0; i < deck.size() - 1; i++) {
				int first_suit, second_suit;
				for(int j = 0; j < suits.size(); j++) {
					if (deck[i].find(suits[j]) != string::npos) {
						first_suit = j;
						break;
					}
				}
				for(int j = 0; j < suits.size(); j++) {
					if (deck[i + 1].find(suits[j]) != string::npos) {
						second_suit = j;
						break;
					}
				}

				if(first_suit < second_suit) {
					string card = deck[i];
					deck[i] = deck[i + 1];
					deck[i + 1] = card;
					sorted = 0;
				}
			}
		}

		sorted = 0;
		while(!sorted) {
			sorted = 1;
			for(int i = 0; i < deck.size() - 1; i++) {
				int first_suit, second_suit;
				for(int j = 0; j < suits.size(); j++) {
					if (deck[i].find(suits[j]) != string::npos) {
						first_suit = j;
						break;
					}
				}
				for(int j = 0; j < suits.size(); j++) {
					if (deck[i + 1].find(suits[j]) != string::npos) {
						second_suit = j;
						break;
					}
				}
				
				if (first_suit == second_suit) {
					int first_rank, second_rank;
					for(int j = 0; j < ranks.size(); j++) {
						if (deck[i].find(ranks[j]) != string::npos) {
							first_rank = j;
							break;
						}
					}
					for(int j = 0; j < ranks.size(); j++) {
						if (deck[i + 1].find(ranks[j]) != string::npos) {
							second_rank = j;
							break;
						}
					}
					if(first_rank < second_rank) {
						string card = deck[i];
						deck[i] = deck[i + 1];
						deck[i + 1] = card;
						sorted = 0;
					}
				}
			}
		}

		for(int i = 0; i < deck.size(); i++) {
			cout << deck[i] << ' ';
		}

		deck_.set_deck(deck);
	}
};

class Deal : public ExecutableOperation {
public:
	Deal(Deck& deck)
		: ExecutableOperation(deck, "deal") {}

protected:
	void run() {
		if(deck_.deck_size() < deck_.get_hand_count()) {
			throw Exception("ERROR: Not enough cards in deck");
		}
		for(int i = 0; i < deck_.get_hand_count(); i++) {
			cout << deck_.pop_front() << ' ';
		}
	}
};

int main() {
	Deck deck;
    deck.add_operation(new War(deck));
    deck.add_operation(new Belote(deck));
    deck.add_operation(new Santase(deck));
    deck.add_operation(new Size(deck));
    deck.add_operation(new TopCard(deck));
    deck.add_operation(new DrawTopCard(deck));
    deck.add_operation(new BottomCard(deck));
    deck.add_operation(new DrawBottomCard(deck));
    deck.add_operation(new Shuffle(deck));
    deck.add_operation(new Sort(deck));
    deck.add_operation(new Deal(deck));

	string input;
    
    cout << "> ";
    getline(cin, input);
    if (input == "quit") {
        return 0;
    }

    string card;
    vector<string> cards;
    istringstream in(input);
    while (getline(in, card, ' ')) {
		if (card.empty()) {
			continue;
		}
		cards.push_back(card);
    }
    deck.set_started_cards(cards);

	string command;
    while (1) {
	    try {
	    	cout << "> ";
	    	cin >> command;
	    	if (command == "quit") {
	    		return 0;
	    	}
	    	Operation* operation = deck.find_operation(command);
			operation -> execute();


	    } catch (Exception& e) {
	    	e.get_message();
			cout << endl;
	    }
    }

	return 0;
}