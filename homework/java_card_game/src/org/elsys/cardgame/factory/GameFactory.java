package org.elsys.cardgame.factory;

import java.util.List;
import java.util.stream.Collectors;

import org.elsys.cardgame.game.AbstractGame;
import org.elsys.cardgame.operation.BottomCard;
import org.elsys.cardgame.operation.Shuffle;
import org.elsys.cardgame.operation.Size;
import org.elsys.cardgame.operation.TopCard;
import org.elsys.cardgame.api.Card;
import org.elsys.cardgame.api.Game;

public class GameFactory {
	public static void AllOperations(Game game) {
		game.addOperation(new TopCard(game.getDeck()));
		game.addOperation(new BottomCard(game.getDeck()));
		game.addOperation(new Shuffle(game.getDeck()));
		game.addOperation(new Size(game.getDeck()));
	}
	public static Game createWarGame(List<Card> cards) {
		Game game = new AbstractGame(new WarDeck(cards.stream()
				.filter(c -> DeckFactory.defaultWarDeck().getCards()
						.contains(c)).collect(Collectors.toList()), 26));
			AllOperations(game);
		return game;
	}

	public static Game createSantaseGame(List<Card> cards) {
		Game game = new AbstractGame(new SantaseDeck(cards.stream()
				.filter(c -> DeckFactory.defaultSantaseDeck().getCards()
						.contains(c)).collect(Collectors.toList()), 6));
			AllOperations(game);
		return game;
	}

	public static Game createBeloteGame(List<Card> cards) {
		Game game = new AbstractGame(new BeloteDeck(cards.stream()
				.filter(c -> DeckFactory.defaultBeloteDeck().getCards()
						.contains(c)).collect(Collectors.toList()), 8));
			AllOperations(game);
		return game;
	}
}