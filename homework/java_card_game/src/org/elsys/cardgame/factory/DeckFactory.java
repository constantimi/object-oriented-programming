package org.elsys.cardgame.factory;

import static org.elsys.cardgame.api.Rank.ACE;
import static org.elsys.cardgame.api.Rank.EIGHT;
import static org.elsys.cardgame.api.Rank.FIVE;
import static org.elsys.cardgame.api.Rank.FOUR;
import static org.elsys.cardgame.api.Rank.JACK;
import static org.elsys.cardgame.api.Rank.KING;
import static org.elsys.cardgame.api.Rank.NINE;
import static org.elsys.cardgame.api.Rank.QUEEN;
import static org.elsys.cardgame.api.Rank.SEVEN;
import static org.elsys.cardgame.api.Rank.SIX;
import static org.elsys.cardgame.api.Rank.TEN;
import static org.elsys.cardgame.api.Rank.THREE;
import static org.elsys.cardgame.api.Rank.TWO;
import static org.elsys.cardgame.api.Suit.CLUBS;
import static org.elsys.cardgame.api.Suit.DIAMONDS;
import static org.elsys.cardgame.api.Suit.HEARTS;
import static org.elsys.cardgame.api.Suit.SPADES;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.elsys.cardgame.api.Card;
import org.elsys.cardgame.api.Deck;
import org.elsys.cardgame.api.Rank;
import org.elsys.cardgame.api.Suit;
import org.elsys.cardgame.imp.CardImplements;


public class DeckFactory {

	public static Deck defaultWarDeck() {
		List<Suit> warSuit = Arrays.asList(CLUBS, DIAMONDS, HEARTS, SPADES);
		List<Rank> warRank = Arrays.asList(TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN,
				JACK, QUEEN, KING, ACE);
		List<Card> cards = new ArrayList<>();
		for (Suit suit : warSuit) {
			for (Rank rank : warRank) {
				cards.add(new CardImplements(suit, rank));
			}
		}
		WarDeck war = new WarDeck(cards, 26);
		return war;
	}

	public static Deck defaultSantaseDeck() {
		List<Suit> warSuit = Arrays.asList(CLUBS, DIAMONDS, HEARTS, SPADES);
		List<Rank> warRank = Arrays.asList( NINE, JACK, QUEEN, KING, TEN, ACE);
		List<Card> cards = new ArrayList<>();
		for (Suit suit : warSuit) {
			for (Rank rank : warRank) {
				cards.add(new CardImplements(suit, rank));
			}
		}
		SantaseDeck santase = new SantaseDeck(cards, 6);
		return santase;
	}

	public static Deck defaultBeloteDeck() {
		List<Suit> warSuit = Arrays.asList(CLUBS, DIAMONDS, HEARTS, SPADES);
		List<Rank> warRank = Arrays.asList(SIX, SEVEN, EIGHT, NINE, JACK, QUEEN, KING, TEN, ACE);
		List<Card> cards = new ArrayList<>();
		for (Suit suit : warSuit) {
			for (Rank rank : warRank) {
				cards.add(new CardImplements(suit, rank));
			}
		}
		BeloteDeck belote = new BeloteDeck(cards, 8);
		return belote;
	}
}
