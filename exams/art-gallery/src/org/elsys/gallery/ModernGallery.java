package org.elsys.gallery;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Comparator;
import java.util.List;

public class ModernGallery extends Gallery{


	public ModernGallery(int budget) {
		super(budget);
		this.budget = budget;
	}

	/**
	 * Montly cost for running the gallery - 8% of the total price of all paintings.
	 * 
	 * @return
	 */
	public double getMonthlyCost() {
		double total = 0;
		for(Painting p : art) {
			total += p.getPrice();
		}
		return (total * 0.08);
	}

	public boolean monthlyPurchase(List<Painting> paintings) {
			double total = 0;
				for(Painting p : paintings) {
					total += p.getPrice();
					if(budget >= total) {
					art.add(p);
					}else {
						return false;
					}
				}
				
		return true;
	}

	/**
	 * Returns all paintings of the given artist sorted from the most expensive to
	 * the less expensive painting.
	 * @param artist
	 * @return
	 */
	public List<Painting> getPaintingsOf(String artist) {
		List<Painting> paintings = new ArrayList<Painting>();
		
			art.sort(new Comparator<Painting>(){

				@Override
				public int compare(Painting o1, Painting o2) {
					if(o1.getPrice() < o2.getPrice()) {
						return 1;
					}else if(o1.getPrice() == o2.getPrice()) {
						return 0;
					}else {
						return -1;
					}
				}				
			});
		
		for(Painting p : art) {
			if(p.getArtist().equals(artist)) {
				paintings.add(p);
			}
		}
		return paintings;
	}
}
