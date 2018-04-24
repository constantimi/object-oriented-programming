#include "turtle.hh"

#include <iostream>
using namespace std;

int main() {
	PSTurtle t(500, 500);
	Color lime(0.5, 0.5, 0.5);
	t.setup();
	t.set_pendown(true);
	t.forward(100)
	.left(45)
	.forward(100)
	.left(45)
	.forward(100)
	.left(45)
	.forward(100)
	.pensize(5)
	.pencolor(lime)
	.right(45)
	.backward(100)
	.right(45)
	.backward(100)
	.right(45)
	.backward(100)
	.right(45)
	.backward(100);

	return 0;
}

//methods
//forward, backward, right, left
