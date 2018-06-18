package org.elsys.todo.impl;

import java.util.ArrayList;
import java.util.List;

import org.elsys.todo.Criteria;
import org.elsys.todo.Status;
import org.elsys.todo.Task;
import org.elsys.todo.TodoList;

public class TodoListImpl implements TodoList {

	private List<Task> tasks = new ArrayList<Task>();
	
	public TodoListImpl(String input) {
		input = input.trim();
		String[] in = input.split("\\\\s*\\\\|\\\\s*");
	}

	@Override
	public Boolean isCompleted() {
		for (int i = 0; i < tasks.size(); i++) {
			if(tasks.get(i) == null) {
				return false;
			}
		}
		return true;
	}

	@Override
	public Double percentageCompleted() {
	    Double percentage = 0d;	    
	    for (int i = 0; i < tasks.size(); i++) {
	    	if(tasks.get(i).equals(Status.DONE)) {
	    		percentage++;
	    	}
		}
	    
	    percentage = (double) (((int)100 * percentage) / 100);
		return percentage;
	}

	@Override
	public List<Task> getTasks() {
		return tasks;
	}

	@Override
	public TodoList filter(Criteria criteria) {
		List<Task> result = new ArrayList<Task>();
		List<Task> t = new ArrayList<Task>();
		t.addAll(this.tasks);
		
		for (int i = 0; i <  t.size(); i++) {
			if(t.get(i).equals(criteria)) {
				result.add(t.get(i));
			}
		}
		
		TodoList r = new TodoListImpl(result);
		return r;
	}

	@Override
	public TodoList join(TodoList other) {
		List<Task> tasks1 = new ArrayList<Task>();
		tasks1.addAll(this.tasks);
		
		for (int i = 0; i <  other.getTasks().size(); i++) {
			if(!tasks1.contains(other.getTasks().get(i))) {
				tasks1.add(other.getTasks().get(i));
			}
		}

		TodoList td = new TodoListImpl(tasks1);
		return td;
	}

	public TodoListImpl(List<Task> tasks) {
		this.tasks = tasks;
	}

}
