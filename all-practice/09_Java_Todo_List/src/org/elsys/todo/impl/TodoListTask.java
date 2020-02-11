package org.elsys.todo.impl;

import java.util.Arrays;

import org.elsys.todo.Priority;
import org.elsys.todo.Status;
import org.elsys.todo.Task;

public class TodoListTask implements Task {
	
	private Status status;
	
	private String description;
	
	private Priority priority;
	
	private String[] tags;

	public TodoListTask(Status status, String description, Priority priority, String[] tags) {
		super();
		this.status = status;
		this.description = description;
		this.priority = priority;
		this.tags = tags;
	}

	@Override
	public Status getStatus() {
		return this.status;
	}

	@Override
	public String getDescription() {
		return this.description;
	}

	@Override
	public Priority getPriority() {
		return this.priority;
	}

	@Override
	public String[] getTags() {
		return this.tags;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((description == null) ? 0 : description.hashCode());
		result = prime * result + ((priority == null) ? 0 : priority.hashCode());
		result = prime * result + ((status == null) ? 0 : status.hashCode());
		result = prime * result + Arrays.hashCode(tags);
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		TodoListTask other = (TodoListTask) obj;
		if (description == null) {
			if (other.description != null)
				return false;
		} else if (!description.equals(other.description))
			return false;
		if (priority != other.priority)
			return false;
		if (status != other.status)
			return false;
		if (!Arrays.equals(tags, other.tags))
			return false;
		return true;
	}
}
