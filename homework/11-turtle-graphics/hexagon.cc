//-----------------------------------------------------
// NAME: Constantin Mihaylov
// CLASS:  XIb
// NUMBER: 13
// PROBLEM: #2
//----------------------------------------------------


#include <string>
#include <stdio.h>
#include <vector>
#include <cstring>
#include <algorithm>
/* cbrt star example */
#include <math.h> 
#include "svg.hh"
#include "turtle.hh"
#define SIDE 400
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


int main(int argc, const char * argv[]){
	Turtle* tr;
 	if(strcmp(argv[1],"svg") == 0){
 		tr = new SVGTurtle(1000.0, 1000.0);
 	}
 	if(strcmp(argv[1],"eps") == 0){
 		tr = new PSTurtle(1000.0, 1000.0);
 	}

   //HEXAGON
   Color red(1,0,0);
   tr->setup().pendown();
   //center

   	for(int i = 0;i < 4;i++) {
		if(i % 2 == 0) {
			tr->forward(tr->get_width() / 2);
		} else {
			tr->forward(tr->get_height() / 2);
		}
		//center
		tr->moveto(Point(500, 500)).left(90);
	}
	tr->moveto(Point(500,500)).left(180).forward(SIDE).right(120).forward(SIDE).left(120);

	for(int i = 0; i <= 6; i++){
	   tr->pendown()
	   .pencolor(red)  
	   .left(60)
	   .forward(SIDE);
	}    

	return 0;
}