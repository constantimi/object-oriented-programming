package org.elsys.todo.impl;

import org.elsys.todo.Criteria;

public class andCriteria extends abstractCriteria{
	public andCriteria(Criteria criteria1, Criteria criteria2) {
		
		this.predicate = ((abstractCriteria)criteria1).getPredicate().and(((abstractCriteria)criteria2).getPredicate());
	}
}
