#ifndef TURTLE_HH_
#define TURTLE_HH_

#include <iostream>

class Point {
	double x_, y_;
public:
	Point(double x, double y) : x_(x), y_(y) {}

	static Point polar(double angle, double distance);
	static Point cartesian(double x, double y);

	double get_x() const {
		return x_;
	}

	double get_y() const {
		return y_;
	}

	Point& operator+=(const Point& p) {
		x_ += p.x_;
		y_ += p.y_;

		return *this;
	}

	Point& operator-=(const Point& p) {
		x_ -= p.x_;
		y_ -= p.y_;

		return *this;
	}

};

Point operator+(const Point& p1, const Point& p2);
Point operator-(const Point& p1, const Point& p2);
std::ostream& operator<<(std::ostream& out, const Point& p);

class Color {
	double r_, g_, b_;
public:
	Color(double r = 0.0, double g = 0.0, double b = 0.0) : r_(r), g_(g), b_(b) {}

	double red() const {
		return r_;
	}

	double green() const {
		return g_;
	}

	double blue() const {
		return b_;
	}

	static Color gray(double gray) {
		return Color(gray, gray, gray);
	}
};

std::ostream& operator<<(std::ostream& out, const Color& c);

class Turtle {
	double width_, height_;
	Point pos_;
	double heading_;
	bool is_pendown_;
	Color pencolor_;
	double pensize_;
public:
	Turtle(double w, double h)
	: width_(w), height_(h),
	pos_(width_/2.0, height_/2.0),
	heading_(0), is_pendown_(false),
	pencolor_(0, 0, 0),
	pensize_(1)
	{}

	virtual ~Turtle() {
	}

	virtual void setup() {
	}

	bool is_pendown() const {
		return is_pendown_;
	}

	Turtle& set_pendown(bool down) {
		is_pendown_ = down;
		return *this;
	}

	const Point& get_pos() const {
		return pos_;
	}

	double get_width() const {
		return width_;
	}

	double get_height() const {
		return height_;
	}

	double get_heading() const {
		return heading_;
	}

	Turtle& set_heading(double heading) {
		heading_ = heading;
		return *this;
	}

	double get_pensize() const {
		return pensize_;
	}

	Turtle& set_pensize(double pensize) {
		pensize_ = pensize;
		return *this;
	}

	const Color& get_color() const {
		return pencolor_;
	}

	Turtle& set_color(const Color& pencolor) {
		pencolor_ = pencolor;
		return *this;
	}

	Turtle& left(double angle) {
		heading_ += angle;
		return *this;
	}

	Turtle& right(double angle) {
		heading_ -= angle;
		return *this;
	}

	virtual Turtle& moveto(const Point& next_pos) {
		pos_ = next_pos;
		return *this;
	}

	virtual Turtle& forward(double distance) = 0;
	virtual Turtle& backward(double distance) = 0;
	virtual Turtle& pensize(double width = 1.0) = 0;
	virtual Turtle& pencolor(const Color& c) = 0;
};

class PSTurtle: public Turtle {
	std::ostream& out_;
public:
	PSTurtle(double w, double h, std::ostream& out=std::cout)
	: Turtle(w, h), out_(out)
	{}

	~PSTurtle();

	void setup();
	Turtle& moveto(const Point& next_pos);
	Turtle& forward(double distance);
	Turtle& backward(double distance);
	Turtle& pensize(double width = 1.0);
	Turtle& pencolor(const Color& c);
};

#endif
