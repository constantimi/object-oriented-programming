#include <iostream>

void copy(int dst[], int src[], int size){
	for (int i = 0; i < size; ++i)
	{
		dst[i] = src[i];	
	}
}

int main(void){
	int a[10], b[10];
	for(int i = 0; i < 10; i++){
		a[i] = i*10;
	}
	
	copy((int*)b,(int*)a,10);
	
	for(int i = 0; i < 10; i++){
		std::cout << b[i] << "; ";
	}
		
		std::cout << std::endl;
	
	return 0;
}