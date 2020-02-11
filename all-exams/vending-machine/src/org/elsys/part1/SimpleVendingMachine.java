package org.elsys.part1;

import java.util.ArrayList;
import java.util.List;

public class SimpleVendingMachine {

	protected List<Product> prList = new ArrayList<Product>();
	protected int revenue = 0;
	
	public SimpleVendingMachine() {
	}

	/**
	 * Adds a product to the vending machine.
	 * 
	 * @param b
	 *            the Product to be added
	 * @return true if b was successfully added
	 */
	public boolean add(Product p) {
		return prList.add(p);
	}

	/**
	 * Adds all products to the vending machine.
	 * 
	 * @param products to add
	 * @return
	 */
	public boolean addAll(List<Product> products) {
		return prList.addAll(products);
	}

	/**
	 * Sells a product from the vending machine.
	 * 
	 * @param p
	 *            the Product to be sold
	 * @return change to return to the client
	 * 
	 * @throws {@link
	 *             RuntimeException} if product is not present in the vending
	 *             machine or if the inserted money are not enough
	 */
	public double sell(String product, double insertedMoney){

			for(Product pr : prList) {
				if(pr.getName().equals(product)) {
					if(pr.getPrice() <= insertedMoney) {
						revenue += insertedMoney;
						prList.remove(pr);					
						break;
					}else {
						throw new RuntimeException();
					}
				}else {
					throw new RuntimeException();
				}
			}
		
		return 0;
	}

	/**
	 * Returns the collected money.
	 * 
	 * @return
	 */
	public double getRevenue() {
		return revenue;
	}

	/**
	 * Returns the total count of products in the vending machine.
	 * 
	 * @return
	 */
	public int size() {
		return prList.size();
	}

	/**
	 * Removes all products from the vending machine.
	 */
	public void clear() {
		for(Product pr : prList) {
			prList.remove(pr);
		}
	}

	/**
	 * Checks whether a Product is present in the vending machine.
	 * 
	 * @param b
	 *            the Product to check
	 * @return true if b is present
	 */
	public boolean contains(Product b) {
		return prList.contains(b);
	}

}