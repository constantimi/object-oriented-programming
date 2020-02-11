#include <iostream>
#include <vector>
#include <string>
#include <sstream>
#include <algorithm>
#include <random>
 
using namespace std;
class Deck;

class Operation {
    string name_;
 
protected: 
    Deck& data_;
 
public: 
    Operation(Deck& data, string name)
        : data_(data), name_(name) {}
 
    string get_name() const {
        return name_;
    }
 
    virtual void execute() const = 0;
 
};
 
class Games {
    string name_; 
protected: 
    Deck& deck_; 
public:
 
    Games(Deck& deck, string name)
        : deck_(deck), name_(name) {}
 
    string get_name() const {
        return name_;
    }
 
    virtual void sort() = 0;
    virtual void deal() const = 0;
};
 
 
 
class DeckError {
    string message_;
public:
    DeckError(string message)
        : message_(message) {}
 
    string get_message() const {
        return message_;
    }
};
 
class Deck {
    vector<string> data_;
    vector<Games*> games_;
    Games* find_game(string name);
    vector<Operation*> operations_;
    Operation* find_operation(string name);
 
public:
    string pop();
    string erase();
    string back();
    string front();
    vector<string>::iterator begin();
    vector<string>::iterator end();
    string get_elem(int index);
    int size();
    void run();
    void erase(int index);
    void push(string value);
    void add_operation(Operation* operation);
    void add_game(Games* game);
};
class Belote : public Games {
    int get_pos(int index, vector<string> &tmp) {
        return (int)(find(tmp.begin(), tmp.end(), deck_.get_elem(index)) - tmp.begin());
    }
public:
    Belote(Deck& data, string name) :
        Games(data, name) {}
 
    void deal() const{
        for (unsigned i = 0; i < 8; ++i)
            cout << deck_.get_elem(i) << ' ';
        cout << '\n';
        deck_.erase(8);
    }
 
    void sort() {
        string myinit[] = { "C7","D7","H7","S7","C8","D8","H8","S8","C9","D9","H9","S9",
            "CJ","DJ","HJ","SJ","CQ","DQ","HQ","SQ","CK","DK","HK","SK","C10","D10",
            "H10","S10","CA","DA","HA","SA" };
        vector<string> tmp(myinit, myinit + sizeof(myinit) / sizeof(string));
   
        /*int n = deck_.size();
        for (int c = 0; c < (n - 1); c++)
        {
            for (int d = 0; d < n - c - 1; d++)
            {
                if (get_pos(d, tmp) > get_pos((d + 1), tmp))
                {
                    array[d] = array[d + 1];
                    array[d + 1] = swap;
                }
            }
        }*/
    }  
};
class War : public Games{
public:
    War(Deck& data, string name) :
        Games(data, name) {}   
};

class Santace : public Games {
public:
    Santace(Deck& data, string name) :
        Games(data, name) {}
};
 
class Shuffle : public Operation {
public:
    Shuffle(Deck& data, string name) :
        Operation(data, name){}
    void execute() const {
        auto rng = default_random_engine{};
        shuffle(data_.begin(), data_.end(), rng);
    }
};
 
class Size : public Operation {
public:
    Size(Deck& data, string name) :
        Operation(data, name) {}
    void execute() const {
        cout << data_.size() << endl;
    }
};
 
class Top_card : public Operation {
public:
    Top_card(Deck& data, string name) :
        Operation(data, name) {}
    void execute() const {
        cout << data_.back() << endl;
    }
};
 
class Bottom_card : public Operation {
public:
    Bottom_card(Deck& data, string name):
        Operation(data, name){}
    void execute() const {
        cout << data_.front() << endl;
    }
};
 
class Draw_top : public Operation {
public:
    Draw_top(Deck& data, string name) :
        Operation(data, name) {}
 
    void execute() const {
        cout << data_.erase() << endl;
    }
};
 
class Draw_bottom : public Operation {
    public:
        Draw_bottom(Deck& data, string name) :
            Operation(data, name) {}
 
        void execute() const {
            cout << data_.pop() << endl;
        }
};
 
void Deck::run() {
    string token;
    while (true) {
        try {
            cout << "> ";
            getline(cin, token);
            if(token == "quit")break;
            istringstream iss(token);
            string value;
 
            if (iss >> value) {
                push(value);
            }
            else {
                Operation* operation = find_operation(token);
                operation->execute();
                cout << data_.back() << endl;
            }
        }
        catch (DeckError err) {
            cout << err.get_message() << endl;
        }
    }
}
void Deck::add_game(Games* game) {
    games_.push_back(game);
}
 
Games* Deck::find_game(string name) {
    for (vector<Games*>::iterator it = games_.begin(); it != games_.end(); ++it) {
        if ((*it)->get_name() == name) {
            return *it;
        }
    }
    Games*non = NULL;
    return non;
}
 
void Deck::add_operation(Operation* operation) {
    operations_.push_back(operation);
}
 
Operation* Deck::find_operation(string name) {
    for (vector<Operation*>::iterator it = operations_.begin(); it != operations_.end(); ++it) {
        if ((*it)->get_name() == name) {
            return *it;
        }
    }
    throw DeckError("ERROR: Unknown operation");
}
 
string Deck::pop() {
    if (data_.size() == 0) {
        throw DeckError("Not enough values in stack");
    }
    string value = back();
    data_.pop_back();
    return value;
}
string Deck::back() {
    return data_.back();
}
int Deck::size() {
    return data_.size();
}
string Deck::front() {
    return data_.front();
}
string Deck::erase() {
    if (data_.size() == 0) {
        throw DeckError("Not enough values in stack");
    }
    string value = front();
    data_.erase(data_.begin());
    return value;
}
string Deck::get_elem(int index) {
    return (index <= data_.size() && index >= 0) ? data_[index] : "err";
}
vector<string>::iterator Deck::begin() {
    return data_.begin();
}
vector<string>::iterator Deck::end() {
    return data_.end();
}
void Deck::erase(int index) {
    data_.erase(data_.begin(), data_.begin() + index);
}
void Deck::push(string value) {
    data_.push_back(value);
}
 
int main() {
    Deck cards;
    cards.add_operation(new Draw_bottom(cards, "draw_bottom_card"));
    cards.add_operation(new Draw_top(cards, "draw_top_card"));
    cards.add_operation(new Top_card(cards, "top_card"));
    cards.add_operation(new Bottom_card(cards, "bottom_card"));
    cards.add_operation(new Size(cards, "size"));
    cards.add_operation(new Shuffle(cards, "shuffle"));

    cards.run();
    return 0;
}