#include <iostream>
#include <sstream>
 
using namespace std;
 
long gcd(long number1, long number2) {
    long dividor = number1 < number2 ? number1 : number2;
 
    if(dividor < 0) {
        dividor *= -1;
    }
 
    while(number1 % dividor != 0 || number2 % dividor != 0) {
        dividor--;
    }
 
    return dividor;
}
 
class RationalException {
    string err_msg_;
 
public:
    RationalException(string message) : err_msg_(message) {}
 
    string get_err_msg() const {
        return err_msg_;
    }
};
 
class Rational {
    long num_, den_;
 
public:
    Rational(long numerator = 1, long denominator = 1) : num_(numerator), den_(denominator) {}
 
    long get_numerator() const {
        return num_;
    }
 
    long get_denominator() const {
        return den_;
    }
 
    Rational& set_numerator(long num) {
        num_ = num;
 
        return *this;
    }
 
    Rational& set_denominator(long den) {
        den_ = den;
 
        return *this;
    }
 
    Rational& add(const Rational& r) {
        num_ = num_ * r.den_ + den_ * r.num_;
        den_ = den_ * r.den_;
 
        return *this;
    }
 
    Rational& sub(const Rational& r) {
        num_ = num_ * r.den_ - den_ * r.num_;
        den_ = den_ * r.den_;
 
        return *this;
    }
 
    Rational& mul(const Rational& r) {
        num_ *= r.num_;
        den_ *= r.den_;
 
        return *this;
    }
 
    Rational& div(const Rational& r) {
        num_ *= r.den_;
        den_ *= r.num_;
 
        return *this;
    }
 
    void simple() {
        long dividor = gcd(num_, den_);
 
        num_ /= dividor;
        den_ /= dividor;
    }
};
 
 
Rational operator+(const Rational& r1, const Rational& r2) {
    Rational result(r1.get_numerator(), r1.get_denominator());
 
    result.add(r2);
 
    return result;
}
 
Rational operator-(const Rational& r1, const Rational& r2) {
    Rational result(r1.get_numerator(), r1.get_denominator());
 
    result.sub(r2);
 
    return result;
}
 
Rational operator*(const Rational& r1, const Rational& r2) {
    Rational result(r1.get_numerator(), r1.get_denominator());
 
    result.mul(r2);
 
    return result;
}
 
Rational operator/(const Rational& r1, const Rational& r2) {
    Rational result(r1.get_numerator(), r1.get_denominator());
 
    result.div(r2);
 
    return result;
}
 
ostream& operator<<(ostream& out, const Rational& r) {
    out << "(" << r.get_numerator() << "/" << r.get_denominator() << ")";
 
    return out;
}
 
bool check_stream_symbol(char c, char symbol, istream& in) {
    if(c != symbol) {
        in.clear(ios_base::badbit);
 
        return false;
    }
 
    return true;
}
 
 
istream& operator>>(istream& in, Rational& r) {
    long num, den;
 
    char c;
 
    in >> c;
 
    if(!check_stream_symbol(c, '(', in)) return in;
 
    in >> num >> c;
 
    if(!check_stream_symbol(c, '/', in)) return in;
 
    in >> den >> c;
 
    if(!check_stream_symbol(c, ')', in)) return in;
 
    if(in.good()) {
        if(den == 0) {
            r.set_numerator(0);
            r.set_denominator(1);
           
            return in;
        }
       
        r.set_numerator(num);
        r.set_denominator(den);
    }
 
    return in;
}
 
int main() {
    try {
        string input;
 
        while(true) {
            cout << "> ";
 
            getline(cin, input);
 
            if (input == "q") {
                break;
            }
 
            istringstream in(input);
 
            Rational result;
 
            in >> result;
 
            if(!in.good()) {
                throw RationalException("Please enter a valid rational number!");
            }
 
            char operation;
 
            in >> operation;
 
            while(operation != '=') {
                Rational rNum;
 
                in >> rNum;
 
                if(!in.good()) {
                    throw RationalException("Please enter a valid rational number!");
                }
 
                if(operation == '+') {
                    result = result + rNum;
                } else if(operation == '-') {
                    result = result - rNum;
                } else if(operation == '*') {
                    result = result * rNum;
                } else if(operation == '/') {
                    result = result / rNum;
                }
 
                in >> operation;
            }
 
            if(result.get_numerator() != 0 && result.get_denominator() != 0) {
                result.simple();
            } else {
                result.set_numerator(0);
                result.set_denominator(1);
            }
 
            cout << result << endl;
        }
    } catch (RationalException rex) {
        cout << rex.get_err_msg() << endl;
 
        main();
    }
 
    return 0;

    }