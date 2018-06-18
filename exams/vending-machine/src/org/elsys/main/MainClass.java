package org.elsys.main;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import org.elsys.part1.Product;

public class MainClass {
	public static void main() {
		List<Product> prList = new ArrayList<Product>();
		Scanner sc = new Scanner(System.in);
		String[] line;
		String[] product;
		
		while(sc.hasNext()) {
			line = sc.nextLine().split(";");
			for(String l : line) {
				product = l.split(", ");
				prList.add(new Product(product[0],Double.parseDouble(product[1])));
			}
		}
		
		
	
		//AdvancedVendingMachine(prList);
	}

}
