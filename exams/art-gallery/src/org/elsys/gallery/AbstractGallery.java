package org.elsys.gallery;

import java.util.ArrayList;
import java.util.List;

public abstract class AbstractGallery {
	
	public AbstractGallery(String artist, String title, int year, double price) {
		super();
		// TODO Auto-generated constructor stub
	}
	
	protected List<Painting> art = new ArrayList<Painting>();
	protected double monthlyCost;
	protected int budget;
	
	public List<Painting> getArt() {
		return art;
	}
	public double getMonthlyCost() {
		return monthlyCost;
	}
	public void setMonthlyCost(double monthlyCost) {
		this.monthlyCost = monthlyCost;
	}
	public int getBudget() {
		return budget;
	}


}
