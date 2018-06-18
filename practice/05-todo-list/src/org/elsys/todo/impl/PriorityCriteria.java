package org.elsys.todo.impl;

import org.elsys.todo.Priority;

public class PriorityCriteria extends AbstractCriteria {
	
	private Priority priority;
	
	public PriorityCriteria(Priority priority) {
		this.priority = priority;
		this.criteriaType = t -> t.getPriority().equals(priority);
	}
	
	public Priority getPriority() {
		return priority;
	}

	public void setPriority(Priority priority) {
		this.priority = priority;
	}
}
