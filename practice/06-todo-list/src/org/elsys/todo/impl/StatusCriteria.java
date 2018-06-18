package org.elsys.todo.impl;

import org.elsys.todo.Status;

public class StatusCriteria extends AbstractCriteria {

	private Status status;
	
	public StatusCriteria(Status status) {
		this.status = status;
		this.criteriaType = t -> t.getStatus().equals(status);
	}
	
	public Status getStatus() {
		return status;
	}

	public void setStatus(Status status) {
		this.status = status;
	}
}
