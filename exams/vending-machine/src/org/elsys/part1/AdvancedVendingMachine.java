package org.elsys.part1;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashSet;
import java.util.List;

public class AdvancedVendingMachine extends SimpleVendingMachine{

	/**
	 * Changes the price to all products with name {@code productName} to
	 * {@code newPrice}
	 * 
	 * @param productName
	 *            name of the products to change price
	 * @param newPrice
	 *            new price of the products
	 */

	public void changePriceOf(String productName, double newPrice) {
			for(Product pr : prList) {
				if(pr.getName().equals(productName)) {
					prList.remove(pr);
					prList.add(new Product(productName, newPrice));
				}
			}
	}

	/**
	 * Returns the products with unique names starting from the cheapest one to the
	 * most expensive.
	 * 
	 * @return
	 */
	public List<Product> getUniqueProductsFromCheapest() {

			
			Collections.sort(prList, new Comparator<Product>() {

				@Override
				public int compare(Product o1, Product o2) {
					if(o1.getPrice() > o2.getPrice()) {
						return 1;
					}else if(o1.getPrice() == o2.getPrice()){
						return 0;
					}else {
						return -1;
					}
				}
			});
			
			List<Product> l = new ArrayList<Product>(new HashSet<>(prList));	
			return l;
	}
	
	public double sell(String product, double insertedMoney){
		double money = 0.0;
		for(Product pr : prList) {
			if(pr.getName().equals(product)) {
				if(pr.getPrice() <= insertedMoney) {
					money += insertedMoney - pr.getPrice();
					revenue += insertedMoney - pr.getPrice();;
					prList.remove(pr);	
					break;
				}else {
					throw new RuntimeException();
				}
			}else {
				throw new RuntimeException();
			}
		}
	
	return money;
}
	

}