package udemy;

public class MyDate {
	private int day;
	private int month;
	private int year;
	
	
	// Constructors:
	//	1. Same name as the class
	//  2. No return type
	
	// The no-args constructor
	public MyDate() {
		
	}
	
	// Constructor that takes 3 arguments
	public MyDate(int date, int month, int year) {
		super();
		this.day = date;
		this.month = month;
		this.year = year;
	}
	
	// Methods
	public void setDate(int m, int d, int y) {
		day = d;
		year = y;
		month = m;
	}
	
	public String toString() {
		return month + "/" + day + "/" + year;
	}

	private int getDay() {
		return day;
	}


	private void setDay(int day) {
		this.day = day;
	}


	private int getMonth() {
		return month;
	}


	private void setMonth(int month) {
		this.month = month;
	}


	private int getYear() {
		return year;
	}


	private void setYear(int year) {
		this.year = year;
	}


	public static void main(String[] args) {
		MyDate date1 = new MyDate(11,11,1918); 
		 
		  MyDate date2 = new MyDate();
		  date2.day = 11;
		  date2.month = 11;
		  date2.year = 1918; 
		 
		  MyDate date3 = new MyDate();
		  date3.setDate(4,21,1968); 
		 
		  String str1 = date1.toString();
		  String str2 = date2.toString();
		  String str3 = date3.toString(); 
		 
		  System.out.println(str1);
		  System.out.println(str2);
		  System.out.println(str3); 
	}
}
