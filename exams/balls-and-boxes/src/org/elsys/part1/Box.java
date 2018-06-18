package org.elsys.part1;

import java.lang.RuntimeException;
import java.util.Collections;
import java.util.Comparator;
import java.util.Iterator;


public class Box extends BallContainer {

	private Double capacity;
	public Box(double capacity) throws RuntimeException{
		this.setCapacity(capacity);
	}

	public Iterator<Ball> getBallsFromBiggest() {
		Collections.sort(super.balls, new  Comparator<Ball>() {

			@Override
			public int compare(Ball o1, Ball o2) {
				if(o1.getVolume() > o2.getVolume()) {
					return 1;
				}else if(o1.getVolume() < o2.getVolume()) {
					return -1;
				}
				return 0;
			}
		});
		return null;
	}

	public Double getCapacity() {
		return capacity;
	}

	public void setCapacity(Double capacity) {
		this.capacity = capacity;
	}	
	
}