package org.elsys.cardgame.factory;

import java.util.List;

import org.elsys.cardgame.api.Card;


public class WarDeck extends AbstractDeck{


	public WarDeck(List<Card> cards, int handsize) {
		super(cards, handsize);
	}
	

	@Override
	public int symbolRankToInt(String symbol) {
			int resultInt;
			switch(symbol) {
			case "2":   resultInt = 2;
				break;
			case "3":   resultInt = 3;
				break;
			case "4": 	resultInt = 4;
				break;
			case "5":	resultInt = 5;
				break;
			case "6":	resultInt = 6;
				break;
			case "7":	resultInt = 7;
				break;
			case "8":	resultInt = 8;
				break;
			case "9":	resultInt = 9;
				break;
			case "10":	resultInt = 10;
				break;
			case "J":	resultInt = 11;
				break;
			case "Q":	resultInt = 12;
				break;
			case "K":	resultInt = 13;
				break;
			case "A":	resultInt = 14;
				break;
			default: resultInt = 0;
				break;
			}
			return resultInt;
	}

}
