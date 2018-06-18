package org.elsys.todo.impl;

import org.elsys.todo.Criteria;

public class NegationCriteria extends AbstractCriteria {

	public NegationCriteria(Criteria criteria) {
		this.criteriaType = ((AbstractCriteria)criteria).getCriteriaType().negate();
	}
}
