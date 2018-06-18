package org.elsys.todo.impl;


import java.util.Arrays;

import org.elsys.todo.Priority;
import org.elsys.todo.Status;
import org.elsys.todo.Task;

public class TaskImpl implements Task{
	private Status status_;
	private String description_;
	private Priority priority_;
	private String[] tags_;
	
	public TaskImpl(Status status_, String description_, Priority priority_, String[] tags_) {;
		this.status_ = status_;
		this.description_ = description_;
		this.priority_ = priority_;
		this.tags_ = tags_;
	}

	@Override
	public Status getStatus() {
		return status_;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((description_ == null) ? 0 : description_.hashCode());
		result = prime * result + ((priority_ == null) ? 0 : priority_.hashCode());
		result = prime * result + ((status_ == null) ? 0 : status_.hashCode());
		result = prime * result + Arrays.hashCode(tags_);
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
		TaskImpl other = (TaskImpl) obj;
		if (description_ == null) {
			if (other.description_ != null)
				return false;
		} else if (!description_.equals(other.description_))
			return false;
		if (priority_ != other.priority_)
			return false;
		if (status_ != other.status_)
			return false;
		if (!Arrays.equals(tags_, other.tags_))
			return false;
		return true;
	}

	@Override
	public String getDescription() {
		return description_;
	}

	@Override
	public Priority getPriority() {
		return priority_;
	}

	@Override
	public String[] getTags() {
		return tags_;
	}

}
