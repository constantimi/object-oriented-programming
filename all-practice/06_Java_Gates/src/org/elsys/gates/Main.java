package org.elsys.gates;
import java.util.Scanner;

public class Main extends GateFactory{
	
	public static Gate EightBitsSumator(String a, String b) {
		System.out.println(a);
		System.out.println(b);
		return null;		
	}

	public static void main(String[] args) {
		int a, b;
		Scanner sc = new Scanner(System.in);
		a = sc.nextInt();
		String binaryA = Integer.toBinaryString(a);
		b = sc.nextInt();
		String binaryB = Integer.toBinaryString(b);
		
		System.out.println(EightBitsSumator(binaryA, binaryB));
	}

}
