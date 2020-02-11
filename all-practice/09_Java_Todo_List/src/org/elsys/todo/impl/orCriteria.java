package org.elsys.todo.impl;

import org.elsys.todo.Criteria;

public class orCriteria extends abstractCriteria{

	public orCriteria(Criteria criteria1, Criteria criteria2) {
		this.predicate = ((abstractCriteria)criteria1).getPredicate().or(((abstractCriteria) criteria2).getPredicate());
	}

}
