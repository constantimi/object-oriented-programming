package org.elsys.todo.impl;

import org.elsys.todo.Criteria;

public class notCriteria extends abstractCriteria{

	public notCriteria(Criteria criteria) {
		this.predicate = ((abstractCriteria)criteria).getPredicate().negate();
	}


}
