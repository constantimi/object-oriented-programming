package org.elsys.cardgame.game;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.elsys.cardgame.api.CardException;
import org.elsys.cardgame.api.Deck;
import org.elsys.cardgame.api.Game;
import org.elsys.cardgame.api.Hand;
import org.elsys.cardgame.api.Operation;
import org.elsys.cardgame.factory.WarDeck;
import org.elsys.cardgame.operation.Deal;

public class AbstractGame implements Game {

	private Deck deck;
	
	private final List<Operation> commonOperations =
			Arrays.asList(new Deal(deck));

	private Hand hand;

	private Map<String, Operation> operations;

	public AbstractGame(Deck deck) {
		this.deck = deck;
		this.operations = new HashMap<>();
		
		List<Operation> allOperations = new ArrayList<>();
		allOperations.addAll(commonOperations);

		for (Operation operation : allOperations) {
			this.operations.put(operation.getName(), operation);
		}
	}

	@Override
	public Deck getDeck() {
		return deck;
	}

	@Override
	public Hand getDealtHand() {
		return hand;
	}

	@Override
	public void setDealtHand(Hand hand) {
		this.hand = hand;
	}

	@Override
	public void process(String command) {
		Operation operation = operations.get(command);
		if (operation != null) {
			operation.execute();
		} else {
			throw new CardException("ERROR: Unknown command.");
		}
	}

	@Override
	public void addOperation(Operation operation) {
		this.operations.put(operation.getName(), operation);
	}

}
