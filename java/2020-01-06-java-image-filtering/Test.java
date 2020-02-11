package grayscale;

import java.io.File;

public class Test {
	
	public static void main(String[] args) {
		File input = new File("/home/constantin/Desktop/java.jpg");
		File output = new File("/home/constantin/Desktop/grayscale.jpg");

		GrayScale.toGrayScale(input, output);
		System.out.println("Completed.");
	}
	
}
