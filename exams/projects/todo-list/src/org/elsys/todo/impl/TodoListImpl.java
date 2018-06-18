package org.elsys.todo.impl;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.function.Consumer;
import java.util.stream.Collectors;

import org.elsys.todo.Criteria;
import org.elsys.todo.Priority;
import org.elsys.todo.Status;
import org.elsys.todo.Task;
import org.elsys.todo.TodoList;

public class TodoListImpl implements TodoList {

	private List<Task> tasks;

	/**
	 * TODO    | Do OOP homework              | Low    | school, programming
	 * TODO    | Get 8 hours of sleep.        | Low    | health
	 * DOING   | Party hard.                  | Normal | social
	 * DONE    | Netflix and chill.           | Normal | tv shows
	 * TODO    | Find missing socks.          | Low    | meh

	 * @param input
	 */
	public TodoListImpl(String input) {
		tasks = Arrays.stream(input.split("\n")).map(line -> {
			String[] splitted = Arrays.stream(line.split("\\|"))
				.map(String::trim)
				.toArray(size -> new String[size]);
			return new TaskImpl(
					Status.valueOf(splitted[0].toUpperCase()),
					splitted[1],
					Priority.valueOf(splitted[2].toUpperCase()),
					splitted[3].split(", "));
		}).collect(Collectors.toList());
	}

	public TodoListImpl(List<Task> list) {
		tasks = list;
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
	public Double completedPercentage() {
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
	public Double statusPercentage(Status status) {
		Double percentage = 0d;	    
	    for (int i = 0; i < tasks.size(); i++) {
	    	if(tasks.get(i).equals(status)) {
	    		percentage++;
	    	}
		}
	    
	    percentage = (double) (((int)100 * percentage) / 100);
		return percentage;
	}

	@Override
	public Double matchingPercentage(Criteria criteria) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<Task> getTasks() {
		return tasks;
	}

	@Override
	public int count(Criteria criteria) {
		
		return 10;
	}

	@Override
	public void each(Consumer<Task> consumer) {
		// TODO Auto-generated method stub
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

	public void TodoListImpl1(List<Task> tasks) {
		this.tasks = tasks;
	}

	
}
