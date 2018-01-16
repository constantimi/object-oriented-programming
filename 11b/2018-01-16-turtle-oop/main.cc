#include<iostream>
#include"turtle.hh"

using namespace std;

int main(){
 PSTurtle t(500, 500);
	t.setup();
	t.moveto(Point(100,0))
	.moveto(Point(100,100))
	.moveto(Point(0,100))
	.moveto(Point(0,0));


return 0;
}
