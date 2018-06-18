package org.elsys.gallery;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

public class Gallery {

	protected List<Painting> art = new ArrayList<Painting>();
	protected double monthlyCost;
	protected int budget;

	/*
	 * public void setBudget(int budget) { this.budget = budget; }
	 */
	public void setMonthlyCost(double monthlyCost) {
		this.monthlyCost = monthlyCost;
	}

	public Gallery(int budget) {
		this.budget = budget;
	}

	/**
	 *
	 * @return gallery budget.
	 */
	public int getBudget() {
		return budget;
	}

	/**
	 * Montly cost for running the gallery - 10% of the total price of all
	 * paintings.
	 * 
	 * @return
	 */
	public double getMonthlyCost() {
		double total = 0;

		for (Painting p : art) {
			total += p.getPrice();
		}
		return (total * 0.1);

	}

	/**
	 * Calculates the monthly budget that could be spend on buying new paintings.
	 * 
	 * @return
	 */
	public double getRemainingMonthlyBudget() {
		/*
		 * double monthlycostOfPainting = 0; for(Painting p : art) {
		 * if(monthlycostOfPainting <= budget - getMonthlyCost()) {
		 * monthlycostOfPainting += p.getPrice(); } }
		 */
		return budget - getMonthlyCost();
	}

	/**
	 * Add painting to the gallery collection.
	 * 
	 * If there is a painting in gallery collection with the same author and name,
	 * throws RuntimeException because of forgery suspected.
	 * 
	 * @param painting
	 *            - painting to be added
	 * @return true if p was successfully added, false otherwise.
	 */
	public boolean add(Painting painting) {
		for(Painting p : art) {
			if(painting.getArtist().equals(p.getArtist()) && painting.getTitle().equals(p.getTitle())){
				throw new RuntimeException();
			}
		}
		return art.add(painting);
	}

	public boolean addAll(Collection<Painting> paintings) {
		return art.addAll(paintings);
	}

	/**
	 * Purchases paintings for the gallery collection.
	 * 
	 * If there is a painting in gallery collection with the same author and name,
	 * throws RuntimeException because of forgery suspected.
	 * 
	 * If the monthly budget is not enough to buy all the paintings throws
	 * RuntimeException.
	 * 
	 * @param paintings
	 *            - paintings to buy
	 * @return true if all are paintigns are purchased.
	 */
	public boolean monthlyPurchase(List<Painting> paintings) {
		double money = 0;
		for (Painting p1 : art) {
			for (Painting p2 : paintings) {

				if (p1.getArtist().equals(p2.getArtist()) && p1.getTitle().equals(p2.getTitle())) {
					throw new RuntimeException();
				} else {
					money += p2.getPrice();
				}
			}
		}
		if (budget < money) {
			throw new RuntimeException();
		}

		return true;
	}

	public int size() {
		return art.size();
	}

	/**
	 * If there is a painting in gallery collection with the same artist and title,
	 * returns true. Otherwise returns false
	 * 
	 * @param painting
	 * @return
	 */
	public boolean contains(Painting painting) {
		return art.contains(painting);
	}
}
