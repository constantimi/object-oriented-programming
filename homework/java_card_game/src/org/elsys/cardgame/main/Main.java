package org.elsys.cardgame.main;

import java.util.List;
import java.util.Scanner;

import org.elsys.cardgame.api.Card;
import org.elsys.cardgame.api.Rank;
import org.elsys.cardgame.api.Suit;
import org.elsys.cardgame.imp.CardImplements;

public class Main {
	public static void main(String[] args) { 
		List<Card>l;
		
		Scanner sc = new Scanner(System.in);
		String line = sc.nextLine();
        line = line.trim();
        sc.close();
        String [] res = line.split("[^a-zA-Z]+");
        
        
        for (int i = 0; i < res.length; i++) {

          // Suit suit =  Suit.valueOf(res[i].charAt(0));
          //Rank rank = res[i].substring(1);
          // Card card = new CardImplements( suit, rank);
          //  l.add(card);
		}
	}
}
