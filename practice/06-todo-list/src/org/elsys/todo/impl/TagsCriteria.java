package org.elsys.todo.impl;

import java.util.Arrays;

public class TagsCriteria extends AbstractCriteria {

	private String[] tags;
	
	public TagsCriteria(String[] tags) {
		this.tags = tags;
		for(String tag : tags) {
			this.criteriaType = t -> Arrays.asList(t.getTags()).contains(tag);
		}
	}
	
	public String[] getTags() {
		return tags;
	}

	public void setTags(String[] tags) {
		this.tags = tags;
	}
}
