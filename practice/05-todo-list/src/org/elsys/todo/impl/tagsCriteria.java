package org.elsys.todo.impl;

import java.util.Arrays;

public class tagsCriteria extends abstractCriteria{
	private String[] tags;

	public tagsCriteria(String[] tags) {
		this.tags = tags;
		for(String tag : tags) {
			this.predicate = t -> Arrays.asList(t.getTags()).contains(tag);
		}

	}

	public String[] getTags() {
		return tags;
	}

	public void setTags(String[] tags) {
		this.tags = tags;
	}
	
}
