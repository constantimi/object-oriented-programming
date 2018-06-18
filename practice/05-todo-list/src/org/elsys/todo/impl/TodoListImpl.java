package org.elsys.todo.impl;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import org.elsys.todo.Criteria;
import org.elsys.todo.Priority;
import org.elsys.todo.Status;
import org.elsys.todo.Task;
import org.elsys.todo.TodoList;

public class TodoListImpl implements TodoList {

	private List<Task> tasks = new ArrayList<>();
	
	public TodoListImpl(String input) {
		/*TODO    | Do OOP homework              | Low    | school, programming
		  TODO    | Get 8 hours of sleep.        | Low    | health
		  DOING   | Party hard.                  | Normal | social
		  DONE    | Netflix and chill.           | Normal | tv shows
		  TODO    | Find missing socks.          | Low    | meh*/
		
		String tasksStrings[] = input.split("\\r?\\n");
		
		for(String taskString : tasksStrings) {
			String taskFields[] = taskString.trim().split("\\s*\\|\\s*");
			Task task = new TodoListTask(Status.valueOf(taskFields[0].toUpperCase()), taskFields[1], Priority.valueOf(taskFields[2].toUpperCase()), taskFields[3].split(",[ ]*"));
			this.tasks.add(task);
		}
	}
	
	public TodoListImpl(List<Task> tasks1, List<Task> tasks2) {
		this.tasks = new ArrayList<>(tasks1);
		this.tasks.addAll(tasks2);
	}
	
	public TodoListImpl(List<Task> tasks) {
		this.tasks = tasks;
	}
	
	@Override
	public Boolean isCompleted() {
		return this.tasks
				.stream()
				.allMatch(t -> t.getStatus().equals(Status.valueOf("DONE")));
	}

	@Override
	public Double percentageCompleted() {
		double mult = 100.0 / this.tasks.size();
		
		int doneTasksCount = this.tasks
				.stream()
				.filter(t -> t.getStatus().equals(Status.valueOf("DONE")))
				.collect(Collectors.toList()).size();
		
		return Math.round(doneTasksCount * mult) / 100.0;
	}

	@Override
	public List<Task> getTasks() {
		return this.tasks;
	}

	@Override
	public TodoList filter(Criteria criteria) {
		return new TodoListImpl(this.getTasks()
				.stream()
				.filter(((AbstractCriteria)criteria).getCriteriaType())
				.collect(Collectors.toList()));
	}

	@Override
	public TodoList join(TodoList other) {
		TodoList mergedTodoList = new TodoListImpl(this.getTasks(), other.getTasks());
		
		mergedTodoList.getTasks().stream().distinct();
		
		return mergedTodoList;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((tasks == null) ? 0 : tasks.hashCode());
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
		TodoListImpl other = (TodoListImpl) obj;
		if (tasks == null) {
			if (other.tasks != null)
				return false;
		} else if (!tasks.equals(other.tasks))
			return false;
		return true;
	}
}
