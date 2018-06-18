package org.elsys.todo.impl;

import org.elsys.todo.Criteria;

public class OrCriteria extends BinaryCriteria {

	public OrCriteria(Criteria criteria1, Criteria criteria2) {
		super(criteria1, criteria2);
		this.criteriaType = ((AbstractCriteria)criteria1).getCriteriaType().or(((AbstractCriteria)criteria2).getCriteriaType());
	}
}
