package org.elsys.gallery;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class MainClass {
	
	public static void main() {
		List<Painting> p = new ArrayList<>();
		
		Scanner sc =  new Scanner(System.in);
		String[] token;
		String[] painting;
		while(sc.hasNext()) {
			token = sc.nextLine().split(";");
			for(String t : token) {
				painting = t.split(", ");
				if(Double.parseDouble(painting[3]) >= 1000) {
					p.add(new Painting(painting[0], painting[1], Integer.parseInt(painting[2]), Double.parseDouble(painting[3])));
				}
			}
		}
		
		ModernGallery m = new ModernGallery(500);
		try {
			m.monthlyPurchase(p);
		}catch( RuntimeException e) {
			System.out.println("Error: purchase!");
			throw new RuntimeException();
		}
		List<Painting> p2 = new ArrayList<>();
		p2 = m.getPaintingsOf("Artist1");
	
	}

}
