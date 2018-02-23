//-----------------------------------------------------
// NAME: Constantin Mihaylov
// CLASS:  XIb
// NUMBER: 13
// PROBLEM: #1
//----------------------------------------------------
// http://www.ethoberon.ethz.ch/WirthPubl/AD.pdf
//https://en.wikipedia.org/wiki/Sierpi%C5%84ski_curve


#include <string>
#include <stdio.h>
#include <vector>
#include <cstring>
#include <algorithm>
/* cbrt star example */
#include <math.h> 
#include "svg.hh"
#include "turtle.hh"

using namespace std;

SVGTurtle::SVGTurtle(double width, double height, std::ostream& out = cout):
Turtle(width ,height), out_(out){}

SVGTurtle::~SVGTurtle(){
	out_ << "</svg>" << endl; 
	out_ << "</body>" << endl;
	out_ << "</html>" << endl;
}

Turtle& SVGTurtle::setup(){
	out_ << "<!DOCTYPE html>" << endl;
	out_ << "<html>" << endl;
	out_ << "<body>" << endl;
	out_ << "<h1>SVG Turtle Graphics</h1>" << endl;
	out_ << "<svg width=\"" << get_width() << "\" height=""" << get_height() << """>" << endl; 
	Turtle::setup();
	return *this;
}


Turtle& SVGTurtle::moveto(const Point& next_p) {
	assert(is_setup());
	assert(inside(next_p));

	if (is_pendown()) {
		out_ << "<line x1 = \"" << get_pos().get_x() <<"\" y1 = \"" << get_pos().get_y()
		 << "\" x2 = \"" << next_p.get_x() << "\" y2 = \"" << next_p.get_y() << "\" style = \"stroke:rgb(" << get_color().red() * 255 << ","  << get_color().green() * 255 << ","
		 << get_color().blue() * 255  << ");stroke-width:2\" />"<< std::endl;
	} 
	Turtle::moveto(next_p);
	return *this;
}


class Sierpinski{
 	Turtle& turtle_;
	double step_;	

public:
	Sierpinski(Turtle& t);
	void draw_s(int order);
	void draw_a(int order);
	void draw_b(int order);
	void draw_c(int order);
	void draw_d(int order);
	void draw(int order);


	void calc_step(int order);
};

Sierpinski::Sierpinski(Turtle& tr) :
			turtle_(tr), step_(tr.get_width() / 16){}



void Sierpinski::draw_s(int order) {
	assert(order >= 0);
	
		draw_a(order - 1);
		turtle_.set_heading(-90).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(180).forward(step_);
	
		draw_b(order - 1);
		turtle_.set_heading(180).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(90).forward(step_);

		draw_c(order - 1);
		turtle_.set_heading(90).forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(0).forward(step_);

		draw_d(order -1);
		turtle_.set_heading(0).forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(-90).forward(step_);		
	
}


void Sierpinski::draw_a(int order){
 		assert(order >= 0);

	if (order != 0) {
		draw_a(order - 1);
		turtle_.set_heading(-90).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(180).forward(step_);
		draw_b(order -1);
		turtle_.forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(-90).forward(2 * step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(0).forward(step_);
		draw_d(order - 1);
		turtle_.set_heading(0).forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(-90).forward(step_);
		draw_a(order -1);
	}
}

void Sierpinski::draw_b(int order){
 		assert(order >= 0);

	if (order != 0) {
		draw_b(order - 1);
		turtle_.set_heading(180).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(90).forward(step_);
		draw_c(order - 1);
		turtle_.forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(180).forward(2 * step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(-90).forward(step_);
		draw_a(order - 1);
		turtle_.set_heading(-90).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(180).forward(step_);
		draw_b(order - 1);

	}
}

void Sierpinski::draw_c(int order){
 		assert(order >= 0);

	if (order != 0) {

		draw_c(order - 1);
		turtle_.set_heading(90).forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(0).forward(step_);
		draw_d(order - 1);
		turtle_.forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(90).forward(2 * step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(180).forward(step_);
		draw_b(order - 1);
		turtle_.set_heading(180).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(90).forward(step_);
		draw_c(order - 1);
	}
}

void Sierpinski::draw_d(int order){
 		assert(order >= 0);

	if (order != 0) {

		draw_d(order -1);
		turtle_.set_heading(0).forward(step_ );
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(-135).forward(step_);
		turtle_.set_heading(-90).forward(step_);	
		draw_a(order - 1);
		turtle_.forward(step_ );
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(0).forward(2 * step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(90).forward(step_ );
		draw_c(order - 1);
		turtle_.set_heading(90).forward(step_ );
		turtle_.set_heading(135).forward(step_);
		turtle_.set_heading(45).forward(step_);
		turtle_.set_heading(-45).forward(step_);
		turtle_.set_heading(0).forward(step_);
		draw_d(order - 1);
	}
}

void Sierpinski::calc_step(int order) {
	assert(order > 0);
	if(order != 1){
		step_ = turtle_.get_width() / (4 * pow(2, (order + 1)));
	}
}


void Sierpinski::draw(int order) {
	
		calc_step(order);
		turtle_.penup();
		turtle_.moveto(Point(1024,1024));
		if(1 != order){
			turtle_.backward(3*step_ ).left(90).backward(3*step_);
		}else{
			turtle_.backward(3*step_ ).right(90).forward(3*step_);
		}
		turtle_.pendown();
		turtle_.pensize(1);
		draw_s(order);
	
	
}


int main(int argc, const char * argv[]){
	Turtle* tr;
	int i = stoi(argv[2]);
 	if(strcmp(argv[1],"svg") == 0){
 		//tr = new SVGTurtle(1000.0, 1000.0);
 		tr = new SVGTurtle(2048.0, 2048.0);
 	}
 	if(strcmp(argv[1],"eps") == 0){
 		//tr = new PSTurtle(1000.0, 1000.0);
 		tr = new PSTurtle(2048.0, 2048.0);
 	}

 	//Sierpinski
 	tr->setup();
 	Sierpinski s(*tr);
	s.draw(i);
	delete tr;
/*
   //HEXAGON
   Color red(1,0,0);
   tr->setup();
   //center
   tr->penup()
   .left(180)
   .forward(400)
   .right(120)
   .forward(400)
   .left(120);

	for(int i = 0; i <= 6; i++){
	   tr->pendown()
	   .pencolor(red)  
	   .left(60)
	   .forward(400);
	 }
*/

/*
	//STAR
	Color green(0,1,0);
	tr->setup();
	//center
	tr->penup()
	.left(90)
	.backward(7*((double)200*cbrt(3))/6)
	.left(30);

	tr->pendown()
	.pencolor(green)
	.forward(200)
	.left(60)
	.forward(200)
	.right(120)
	.forward(200)
	.left(60)
	.forward(200)
	.right(120)
	.forward(200)
	.left(60)
	.forward(200)
	.left(60)
	.backward(200)
	.left(60)
	.backward(200)
	.right(120)
	.backward(200)
	.left(60)
	.backward(200)
	.right(120)
	.backward(200)
	.left(60)
	.backward(200)
	.pencolor(green);
*/
    

	return 0;
}