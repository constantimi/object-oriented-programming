package org.elsys.cardgame.factory;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

import org.elsys.cardgame.api.Card;
import org.elsys.cardgame.api.Deck;
import org.elsys.cardgame.api.Hand;
import org.elsys.cardgame.imp.HandImplements;

public abstract class AbstractDeck implements Deck {
	
	private List<Card> deck_;
	private int Handsize_;
	
	public AbstractDeck(List<Card> deck,int  Handsize) {
		this.deck_ = deck;
		this.Handsize_ = Handsize;
	}
	public abstract int symbolRankToInt(String symbol);
	
	public int symbolSuitToInt(String symbol) {
		int resultSuit;
		
		switch(symbol) {
		case "C": resultSuit  = 1; 
			break;
			
		case "D": resultSuit  = 2; 
			break;
		
		case "H": resultSuit  = 3; 
			break;
		
		case "S": resultSuit  = 4; 
			break;
		
		default: resultSuit = 0;
			break;
		}
		return resultSuit;
	}
	
	@Override
	public Card drawTopCard() {
		return getCards().remove(0);
	}

	@Override
	public Card topCard() {
		return getCards().get(0);
	}

	@Override
	public Card drawBottomCard() {
		return getCards().remove(deck_.size() - 1);
	}

	@Override
	public Card bottomCard() {
		return getCards().get(deck_.size() - 1);
	}

	@Override
	public Hand deal() {
		List<Card> handCards = new ArrayList<Card>();
		for (int i = 0; i < handSize(); i++) {
			handCards.add(drawTopCard());
		}
		HandImplements hand = new HandImplements(handCards);
		return hand;
	}

	@Override
	public void sort() {
		Comparator<Card> RankComparator = new RankCardComparator();
		Comparator<Card> SuitComparator = new SuitCardComparator();
		
		for(int i = 0; i < (deck_.size() - 1); i++){
			for(int j = 0; j < (deck_.size() - 1 - i); j ++) {
				if(RankComparator.compare(deck_.get(j), deck_.get(j + 1)) == 1) {
				 Collections.swap(deck_, j, j + 1);
				 }
			}
		}
		
		for(int i = 0; i < 3; i++){
			for(int j = 0; j < (3 - i); j ++) {
				if(SuitComparator.compare(deck_.get(j), deck_.get(j + 1)) == 1) {
				 Collections.swap(deck_, j, j + 1);
				 }
			}
		}
	}

	public  class RankCardComparator implements Comparator<Card> {

		@Override
		public int compare(Card o1, Card o2) {
			if(symbolRankToInt(o1.getRank().getSymbol()) > symbolRankToInt(o2.getRank().getSymbol())) {
				return 1;
			}
			return 0;
		}
	}
	
	public  class SuitCardComparator implements Comparator<Card> {

		@Override
		public int compare(Card o1, Card o2) {
			if(symbolSuitToInt(o1.getSuit().getSymbol()) > symbolSuitToInt(o2.getSuit().getSymbol())) {
				return 1;
			}
			return 0;
		}
	}
	
	@Override
	public List<Card> getCards() {
		return deck_;
	}

	@Override
	public int handSize() {
		return Handsize_;
	}
	
	@Override
	public int size() {
		return deck_.size();
	}
	

	@Override
	public void shuffle() {
		Collections.shuffle(deck_);
	}
}