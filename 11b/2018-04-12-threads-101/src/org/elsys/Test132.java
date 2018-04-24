package org.elsys;

class Foo{
	Foo(String s){
		System.out.print(s);
	}
}

class Bar extends Foo{

	Bar(String s) {
		super(s);
		// TODO Auto-generated constructor stub
	} }

public class Test132 {
 public static void main() {
	 new Foo("Foo");
	 new Bar(null);
	 System.out.print(" done");
 }
}
