package org.elsys.todo.options;

import java.util.function.Predicate;

import org.elsys.todo.Task;
import org.elsys.todo.impl.CriteriaImpl;

public class AndCriteria extends CriteriaImpl {


	public AndCriteria(Predicate<Task> criteria1, Predicate<Task> criteria2) {
		super(criteria1, criteria2);
		// TODO Auto-generated constructor stub
	}

	public Predicate<Task> AndCriteria(Predicate<Task> criteria1, Predicate<Task> criteria2) {
		
		return  ((CriteriaImpl) criteria1).getCriteria1().and( ((CriteriaImpl) criteria2).getCriteria2());
		
	}
	
}
