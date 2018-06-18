package org.elsys.todo.impl;

import java.util.function.Predicate;

import org.elsys.todo.Criteria;
import org.elsys.todo.Task;

public class AbstractCriteria implements Criteria {
	
	protected Predicate<Task> criteriaType;
	
	@Override
	public Criteria and(Criteria other) {
		return new AndCriteria(this, other);
	}

	@Override
	public Criteria or(Criteria other) {
		return new OrCriteria(this, other);
	}

	@Override
	public Criteria not() {
		return new NegationCriteria(this);
	}
	
	public Predicate<Task> getCriteriaType() {
		return criteriaType;
	}

	public void setCriteriaType(Predicate<Task> criteriaType) {
		this.criteriaType = criteriaType;
	}
}
