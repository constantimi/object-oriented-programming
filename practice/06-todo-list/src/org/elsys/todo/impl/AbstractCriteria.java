package org.elsys.todo.impl;

import java.util.function.Predicate;

import org.elsys.todo.Criteria;
import org.elsys.todo.Task;
import org.elsys.todo.impl.andCriteria;

public class abstractCriteria implements Criteria {

	protected Predicate<Task> predicate;
	public Predicate<Task> getPredicate() {
		return predicate;
	}

	public void setPredicate(Predicate<Task> predicate) {
		this.predicate = predicate;
	}

	@Override
	public Criteria and(Criteria other) {
	return new andCriteria(this, other);
	}

	@Override
	public Criteria or(Criteria other) {
		
		return new orCriteria(this, other);
	}

	@Override
	public Criteria not() {
		// TODO Auto-generated method stub
		return null;
	}

}
