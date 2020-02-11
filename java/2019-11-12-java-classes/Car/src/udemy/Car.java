package udemy;

public class Car {
	
	private String color;
	private String type;
	
	public Car(String color, String type) {
		super();
		this.color = color;
		this.type = type;
	}

	private String getColor() {
		return color;
	}

	private void setColor(String color) {
		this.color = color;
	}

	private String getType() {
		return type;
	}

	private void setType(String type) {
		this.type = type;
	}

	public static void main(String[] args) {
		Car car = new Car("green", "Skoda");
		
		car.setColor("blue");
		car.setType("Aston Martin DB11");
		System.out.println("This is a " + car.getColor() + " " + car.getType() + ".");
		
		car.setColor("silver");
		car.setType("Aston Martin Vintage");
		System.out.println("This is my favorite car, a " + car.getColor() + " " + car.getType() + ".");
	
	}

}
