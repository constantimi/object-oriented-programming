package org.elsys.cardgame.factory;
import java.util.List;
import org.elsys.cardgame.api.Card;
import org.elsys.cardgame.api.Deck;

public class BeloteDeck extends AbstractDeck implements Deck{
	

	public BeloteDeck(List<Card> cards, int handsize) {
		super(cards, handsize);
	}

	@Override
	public int symbolRankToInt(String symbol) {
		int resultInt;
		switch(symbol) {
		case "7":	resultInt = 7;
			break;
		case "8":	resultInt = 8;
			break;
		case "9":	resultInt = 9;
			break;
		case "J":	resultInt = 10;
			break;
		case "Q":	resultInt = 11;
			break;
		case "K":	resultInt = 12;
			break;
		case "10":	resultInt = 13;
			break;
		case "A":	resultInt = 14;
			break;
		default: resultInt = 0;
			break;
		}
		return resultInt;
	}
}
