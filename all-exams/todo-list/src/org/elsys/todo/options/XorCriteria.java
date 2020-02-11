package org.elsys.todo.options;

import java.util.function.Predicate;

import org.elsys.todo.Task;
import org.elsys.todo.impl.CriteriaImpl;

public class XorCriteria extends CriteriaImpl {

	public XorCriteria(Predicate<Task> criteria1, Predicate<Task> criteria2) {
		super(criteria1, criteria2);
	}
	
	public Predicate<Task> XorCriteria(Predicate<Task> criteria1, Predicate<Task> criteria2) {
		
		return  ((CriteriaImpl) criteria1).getCriteria1().or( ((CriteriaImpl) criteria2).getCriteria2());
		
	}
}
