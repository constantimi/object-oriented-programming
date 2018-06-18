package org.elsys.todo.impl;

import java.util.function.Predicate;

import org.elsys.todo.Criteria;
import org.elsys.todo.Task;

public class CriteriaImpl implements Criteria{

	protected Predicate<Task> criteria1;
	protected Predicate<Task> criteria2;
	
	

	public CriteriaImpl(Predicate<Task> criteria1, Predicate<Task> criteria2) {
		super();
		this.criteria1 = criteria1;
		this.criteria2 = criteria2;
	}

	
	public Predicate<Task> getCriteria1() {
		return criteria1;
	}


	public void setCriteria1(Predicate<Task> criteria1) {
		this.criteria1 = criteria1;
	}


	public Predicate<Task> getCriteria2() {
		return criteria2;
	}


	public void setCriteria2(Predicate<Task> criteria2) {
		this.criteria2 = criteria2;
	}


	@Override
	public Criteria xor(Criteria other) {
		// return new XorCriteria(this, other);
		return null;
	}


	@Override
	public Criteria not() {
		// return new NotCriteria(this, other);
		return null;
	}


	@Override
	public Criteria and(Criteria other) {
		
		//return new AndCriteria(this, other);
		return null;
	}


	@Override
	public Criteria or(Criteria other) {
		//return new OrCriteria(this, other);
		return null;
	}

}
