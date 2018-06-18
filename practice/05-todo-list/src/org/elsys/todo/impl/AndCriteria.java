package org.elsys.todo.impl;

import org.elsys.todo.Criteria;

public class AndCriteria extends BinaryCriteria {

	public AndCriteria(Criteria criteria1, Criteria criteria2) {
		super(criteria1, criteria2);
		this.criteriaType = ((AbstractCriteria)criteria1).getCriteriaType().and(((AbstractCriteria)criteria2).getCriteriaType());
	}
}
