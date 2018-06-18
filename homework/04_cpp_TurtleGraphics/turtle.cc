#include "turtle.hh"

#include <iostream>
#include <cmath>
using namespace std;

Point Point::polar(double angle, double distance) {
	double radians = angle * M_PI / 180.0;
	double x = distance * cos(radians);
	double y = distance * sin(radians);
	return Point(x, y);
}

Point Point::cartesian(double x, double y) {
	return Point(x, y);
}

Point operator+(const Point& p1, const Point& p2) {
	Point p=p1;
	p+=p2;
	return p;
}

Point operator-(const Point& p1, const Point& p2) {
	Point p=p1;
	p-=p2;
	return p;
}

ostream& operator<<(ostream& out, const Point& p) {
	cout << p.get_x() << " " << p.get_y();

	return out;
}

void PSTurtle::setup() {
	out_ << "%!PS-Adobe-3.0 EPSF-3.0" << endl;
	out_ << "%%Creator: turtle" << endl;
	out_ << "%%DocumentData: Clean7Bit" << endl;
	out_ << "%%Origin: 0 0" << endl;
	out_ << "%%BoundingBox: 0 0 "
			<< get_width() << " " << get_height() << endl;
	out_ << "%%LanguageLevel: 2" << endl;
	out_ << "%%Pages: 1" << endl;
	out_ << "%%Page: 1 1" << endl;

	out_ << "newpath" << endl;
	out_ << get_pos() << " moveto" << endl;
}

PSTurtle::~PSTurtle() {
	out_ << "stroke" << endl;
	out_ << "%%EOF" << endl;
}

Turtle& PSTurtle::moveto(const Point& new_pos) {
	if(is_pendown()) {
		out_ << new_pos << " " << "lineto" << endl;
	} else {
		out_ << new_pos << " " << "moveto" << endl;
	}
	Turtle::moveto(new_pos);
	return *this;
}

Turtle& PSTurtle::forward(double distance) {
	Point step = Point::polar(get_heading(), distance);
	Point new_pos = get_pos() + step;
	moveto(new_pos);

	return *this;
}

Turtle& PSTurtle::backward(double distance) {
	Point step = Point::polar(get_heading(), distance);
	Point new_pos = get_pos() - step;
	moveto(new_pos);

	return *this;
}

Turtle& PSTurtle::pensize(double width) {
	out_ << width << " " << "setlinewidth" << endl;

	return *this;
}

Turtle& PSTurtle::pencolor(const Color& c) {
	out_ << c.red() << " " << c.green() << " " << c.blue() << " " << "setrgbcolor" << endl;
	return *this;
}
