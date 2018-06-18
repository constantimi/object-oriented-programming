package org.elsys.cardgame.imp;

import java.util.List;

import org.elsys.cardgame.api.Card;
import org.elsys.cardgame.api.Hand;

public class HandImplements implements Hand {

	private List<Card> handDeck_;
	
	public HandImplements(List<Card> hCards) {
		this.handDeck_ = hCards;
	}

	@Override
	public List<Card> getCards() {
		return handDeck_;
	}

	@Override
	public int size() {
		return handDeck_.size();
	}
}
