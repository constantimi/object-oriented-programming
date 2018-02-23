#include <iostream>

void copy(double dst[], double src[], int size){
	for (int i = 0; i < size; ++i)
	{
		dst[i] = src[i];	
	}
}

int main(void){
	double a[10], b[10];
	for(int i = 0; i < 10; i++){
		a[i] = i*1000.00;
	}
	
	copy((double*)b,(double*)a,10);
	
	for(int i = 0; i < 10; i++){
		std::cout << b[i] << "; ";
	}		
		std::cout << std::endl;
	
	return 0;
}