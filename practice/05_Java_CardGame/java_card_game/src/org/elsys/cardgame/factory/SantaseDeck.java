package org.elsys.cardgame.factory;

import static org.elsys.cardgame.api.Rank.ACE;
import static org.elsys.cardgame.api.Rank.JACK;
import static org.elsys.cardgame.api.Rank.KING;
import static org.elsys.cardgame.api.Rank.NINE;
import static org.elsys.cardgame.api.Rank.QUEEN;
import static org.elsys.cardgame.api.Rank.TEN;
import static org.elsys.cardgame.api.Suit.CLUBS;
import static org.elsys.cardgame.api.Suit.DIAMONDS;
import static org.elsys.cardgame.api.Suit.HEARTS;
import static org.elsys.cardgame.api.Suit.SPADES;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;

import org.elsys.cardgame.api.Card;
import org.elsys.cardgame.api.Deck;
import org.elsys.cardgame.api.Rank;
import org.elsys.cardgame.api.Suit;
import org.elsys.cardgame.imp.CardImplements;

public class SantaseDeck extends AbstractDeck implements Deck{
	
	 SantaseDeck(List<Card> cards, int handsize) {
		super(cards, handsize);
	}

	@Override
	public int symbolRankToInt(String symbol) {
		int resultInt;
		switch(symbol) {
		case "9":	resultInt = 9;
			break;
		case "J":	resultInt = 11;
			break;
		case "Q":	resultInt = 12;
			break;
		case "K":	resultInt = 13;
			break;
		case "10":	resultInt = 10;
			break;
		case "A":	resultInt = 14;
			break;
		default: resultInt = 0;
			break;
		}
		return resultInt;
	}
}
