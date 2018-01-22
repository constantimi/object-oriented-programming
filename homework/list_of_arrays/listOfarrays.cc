//https://www.hackerrank.com/contests/lists-and-arrays/challenges/list-of-arrays/problem

#include <iostream>
#include <list>
#include <string>

using namespace std;

class ListOfArrays {

    class ArrayNode {

        public:

        int* data_;
        int size_;
        ArrayNode* prev_;
        ArrayNode* next_;

        ArrayNode(int* data, int size)
            : data_(data), size_(size), next_(0), prev_(0) {}

        ~ArrayNode() {
            delete [] data_;
        }

    };

    ArrayNode* head_;
    int size_;

    public:

    class Iterator {

        friend class ListOfArrays;

        ListOfArrays& list_;
        ArrayNode* current_;

        public:

        Iterator(ListOfArrays& list, ArrayNode* current)
            : list_(list), current_(current) {}

        bool operator==(const Iterator& other){

        }

        bool operator!=(const Iterator& other){
            
        }

        Iterator& operator++(){
            current_ = current_->next_;
            return *this;
        }

        Iterator operator++(int){
            Iterator previous(list_, current_);
            current_ = current_->next_;
            return *this;
        }

        int& operator[](const int& index){
            return current_->data_[index];
        }
        
        int size(){
            return current_->size_;
        }

        void show(){
            for (int i = 0; i < current_->size_; ++i)
            {
                cout << current_->data_[i]; 
            }
            cout << endl;
        }
        
        double average(){
            double average = sum() / size();
            return average;
        }
        
        double median(){
             int index = (current_->size_ % 2 == 1) ? 
                    current_->size_ / 2 + 1 :
                    current_->size_ / 2;
            return current_->data_[index];
        }
        
        int sum(){
            int sum = 0;
            for (size_t i  = 0; i < current_->size_; ++i)
            {
                 sum += current_->data_[i];
            }
        }
        
        Iterator& ordered(bool ascending = true){
             int i, j, tmp;
                 for(j = 1; j < current_->size_; j++)    
                {
                       tmp = current_->data_[j];
                       for(i = j - 1; (i >= 0); i--)   
                      {
                            if(ascending && (current_->data_[j] > tmp)){
                             //ascending
                             current_->data_[i+1] = current_->data_[i];
                            }else if(current_->data_[j] < tmp){
                             //descending
                             current_->data_[i+1] = current_->data_[i];
                            }
                      }
                     current_->data_[i+1] = tmp;    
                 }
                 return *this;
        }
    };

    ListOfArrays()
            : size_(0), head_(new ArrayNode(0, 0)) {
        head_->next_ = head_;
        head_->prev_ = head_;
    }

	~ListOfArrays(){

    for (Iterator i = this->begin(); i != this->end(); ++i)
        {
            delete i.current_;
        }    
        delete head_;
    }

    ListOfArrays(const ListOfArrays& other): size_(0), head_(new ArrayNode(0,0)){
        head_->next_ = head_;
        head_->prev_ = head_;

        ArrayNode* otherNext = other.head_->next_;

        while(otherNext != other.head_){
            push(otherNext->data_,0, otherNext->size_);

            otherNext = otherNext->next_;
        }
    }

	ListOfArrays& operator=(const ListOfArrays& other){
        if(this != &other){
            size_ = other.size_;

            ArrayNode* front = head_->next_;

            while(front != head_){
                ArrayNode* nextNode = front->next_;
                delete front;
                front = nextNode;
            }

            delete head_;

            head_->next_ = head_;
            head_->prev_= head_;

            ArrayNode* otherNext = other.head_->next_;

            while(otherNext != other.head_){
                push(otherNext->data_, 0, otherNext->size_);

                otherNext = otherNext->next_;
            }
        }
        return *this;
    }

    int size(){
        return size_;
    }

    void push(int array[], int position, int length){
        int array_temp[length];
        int pos = 0;
        for (int i = position; i < position + length; ++i)
        {
            array_temp[pos] = array[i];
            pos++;
        }

        ArrayNode* ptr = new ArrayNode(array_temp, length);
        ArrayNode* back = head_ -> prev_;
        
        back->next_ = ptr;
        ptr->prev_ = back;
        
        ptr->next_ = head_;
        head_->prev_ = ptr;
        size_++;
    }

    void averages(double averages[]){
        int ind = 0;
        averages[size_];
        for(Iterator it = this->begin(); it != this->end(); ++it ){
             averages[ind++] = it.average();
        }
    }

    void medians(double medians[]){
        int ind = 0;
        medians[size_];
        for(Iterator it = this->begin(); it != this->end(); ++it ){
             medians[ind++] = it.median();
        }
    }
    
    void sizes(int sizes[]){
        int ind = 0;
        sizes[size_];
        for(Iterator it = this->begin(); it != this->end(); ++it ){
             sizes[ind++] = it.size();
        }
    }
    
    void sums(int sums[]){
        int ind = 0;
        sums[size_];
        for(Iterator it = this->begin(); it != this->end(); ++it ){
             sums[ind++] = it.sum();
        }
    }

    Iterator begin(){
        return Iterator(*this, head_->next_);
    }

    Iterator end(){
        return Iterator(*this, head_);
    }

    ListOfArrays& ordered(bool ascending = true){
        for (bool sorted = false; sorted == true; ) 
           {  
             sorted = true;

             if(size_ < 2)break;


            } 
        
    }

    ListOfArrays& operator*=(const int& coef);

    ListOfArrays& operator+=(const int& value);

    void show(){
       
    }
    
};

int main(){
    string input;
    int num[10][250];
   
    while(true){
      cout << "> ";
      getline(cin, input);

       if(input == "quit"){
        break;
       }
       int id = 0;
       int length = 0;
       ListOfArrays* l;
       for (int i = 0; input[i] != '\0' ; ++i)
       {         
        
            while(input[i] != ';' && input[i] != ' ' && input[i] != '\0'){
             cout << input[i];
             num[id][length++] = input[i];
             i++;
            }
                   
            if(input[i] != ';'){
                cout << endl;
                cout << num << endl;
                //l->push(,0,length);
                id++;
                length = 0;
            }
              
       }
       
      
    }
    return 0;
}