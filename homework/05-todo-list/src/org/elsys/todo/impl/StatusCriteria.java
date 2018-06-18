package org.elsys.todo.impl;

import org.elsys.todo.Criteria;
import org.elsys.todo.Status;

public class StatusCriteria implements Criteria {

	public StatusCriteria(Status status) {
		Criteria.status(Status.TODO);   
	}

	@Override
	public Criteria and(Criteria other) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Criteria or(Criteria other) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Criteria not() {
		// TODO Auto-generated method stub
		return null;
	}

}
