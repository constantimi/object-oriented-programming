#include "turtle.hh"

#include <iostream>
using namespace std;

int main() {
	PSTurtle t(500, 500);
	Color lime(0.5, 1.0, 0.5);
	t.setup();
	t.set_pendown(true);
	t.forward(100)
	.left(90)
	.forward(100)
	.left(90)
	.forward(100)
	.left(90)
	.forward(100)
	.pensize(10)
	.pencolor(lime)
	.right(90)
	.backward(200)
	.right(90)
	.backward(200)
	.right(90)
	.backward(200)
	.right(90)
	.backward(200);

	return 0;
}

//methods
//forward, backward, right, left
