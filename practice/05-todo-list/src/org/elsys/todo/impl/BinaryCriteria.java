package org.elsys.todo.impl;

import org.elsys.todo.Criteria;

public class BinaryCriteria extends AbstractCriteria {
	
	private Criteria criteria1;
	
	private Criteria criteria2;
	
	public BinaryCriteria(Criteria criteria1, Criteria criteria2) {
		this.criteria1 = criteria1;
		this.criteria2 = criteria2;
	}

	protected Criteria getCriteria1() {
		return criteria1;
	}

	protected void setCriteria1(Criteria criteria1) {
		this.criteria1 = criteria1;
	}

	protected Criteria getCriteria2() {
		return criteria2;
	}

	protected void setCriteria2(Criteria criteria2) {
		this.criteria2 = criteria2;
	}
}
