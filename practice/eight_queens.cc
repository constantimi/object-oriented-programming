#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

class Queens{
	unsigned size_;
	vector<int> board_;

public:
	Queens(unsigned size):
	size_(size), board_(size) 
	{}	
	
	bool check_position(unsigned col,unsigned row){
		for(unsigned i = 0; i < col;i++){
			if(row == board_[i]) return false;
			if(abs(col-row) == abs(i - board_[i])) return false;
		}		
		return true;
	}
	
	void dump(){
		for(unsigned i = 0; i < size_;i++) {
			cout << i << board_[i] << endl;
		}
		cout << endl << endl;
	}

	void queens(unsigned col){
		if(col >= size_){
			dump();
		}	
		for(unsigned row = 0; row < size_; ++row){
			if(check_position(col,row))	{
				board_[col] = row;
				queens(col+1);
			}		

		}
	}
};

int main(){
	Queens q(4);
	q.queens(0);
	return 0;
}
