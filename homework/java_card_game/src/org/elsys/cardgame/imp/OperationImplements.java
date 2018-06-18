package org.elsys.cardgame.imp;

import org.elsys.cardgame.api.Deck;
import org.elsys.cardgame.api.Operation;

public class OperationImplements implements Operation{

	protected String name;
	protected Deck deck;
	public OperationImplements(Deck cards, String string) {
		this.deck = cards;
		this.name = string;
	}

	@Override
	public String getName() {
		return name;
	}

	@Override
	public void execute() {	
	}
}
