package org.elsys.todo.impl;

import java.util.Scanner;

import org.elsys.todo.Criteria;
import org.elsys.todo.Priority;
import org.elsys.todo.TodoList;

public class Main {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		StringBuilder builder = new StringBuilder();
		
		String task;
		
		while (scanner.hasNextLine()) {
			task = scanner.nextLine();
		    if (task.isEmpty()) {
		        break;
		    }
		    builder.append(task).append('\n');
		}
		
		TodoList todoList = new TodoListImpl(builder.toString());
		
		boolean isCompleted = todoList.isCompleted();
		
		Double percentageCompleted = todoList.percentageCompleted();
		
		TodoList basic = todoList.filter(Criteria.priority(Priority.NORMAL));
		
		TodoList and = todoList.filter(Criteria.priority(Priority.LOW).and(Criteria.tags(new String[] { "school" })));
		
		TodoList not = todoList.filter(Criteria.priority(Priority.LOW).not());
		
		TodoList or = todoList.filter(Criteria.tags(new String[] { "school" }).or(Criteria.priority(Priority.HIGH)));
		
		TodoList join = todoList.filter(Criteria.tags(new String[] { "school" })).join(todoList.filter(Criteria.priority(Priority.HIGH)));
		
		System.out.println(or.equals(join));
		
		scanner.close();
	}

}
