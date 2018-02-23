#include <iostream>
#include <algorithm>

using namespace std;

int main(void){
	int a[10], b[10];
	double c[10],d[10],e[10];
	for(int i = 0; i < 10; i++){
		a[i] = i * 1000;
		c[i] = i * 1.1;
		e[i] = 0; 
	}

	//copy_array(b, a, sizeof(a));
	copy_n(a, sizeof(a), b);
	for(int i = 0; i < 10; i++){
		std::cout << b[i] << "; ";
	}
	std::cout << std::endl;

	//copy_array(d, c, sizeof(c));
	copy_n(c, sizeof(c), d);
	for (int i = 0; i < 10; ++i)
	{
		std::cout << d[i] << "; ";
	}
	std::cout << std::endl;

	//copy_array(e, a, sizeof(a));
	copy_n(a, sizeof(a), e);
	for(int i = 0; i < 10; i++){
		std::cout << e[i] << "; ";
	}
	std::cout << std::endl;
	return 0;
}