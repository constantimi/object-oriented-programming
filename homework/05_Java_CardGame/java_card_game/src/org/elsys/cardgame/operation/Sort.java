package org.elsys.cardgame.operation;

import org.elsys.cardgame.api.CardException;
import org.elsys.cardgame.api.Deck;
import org.elsys.cardgame.imp.OperationImplements;

public class Sort extends OperationImplements{

	public Sort(Deck cards) {
		super(cards, "sort");
	}
	
	@Override 
	public void execute() {
		if(deck.size() != 0) {
			deck.sort();
		} else {
			throw new CardException("ERROR: Not enough cards in deck");
		}
	}

}
