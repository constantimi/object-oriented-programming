package org.elsys.cardgame.operation;

import java.util.List;

import org.elsys.cardgame.api.Card;
import org.elsys.cardgame.api.CardException;
import org.elsys.cardgame.api.Deck;
import org.elsys.cardgame.api.Hand;
import org.elsys.cardgame.imp.OperationImplements;

public class Deal extends OperationImplements {
	
	public Deal(Deck cards) {
		super(cards, "deal");
	}
	
	@Override
	public void execute() {
		if(deck.size() != 0) {
			Hand hand = deck.deal();
			List<Card> list = hand.getCards();
			for (int i = 0; i < hand.size(); i++) {
				System.out.println(list.get(i));
			}
		} else {
			throw new CardException("ERROR: Not enough cards in the deck");
		}
	}

}
