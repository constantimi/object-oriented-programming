package org.elsys.edu;

import java.util.ArrayList;
import java.util.List;

public class Student {
	private double avgGrade_;
	private List<Subject> unsb_ = new ArrayList<Subject>();
	private List<Subject> sb_ = new ArrayList<Subject>();
	private String name_;
	private int course_;
	
	public Student( List<Subject> sb_, String name_, int course_, double avgGrade_) {
		this.sb_ = sb_;
		this.avgGrade_ = avgGrade_;
		this.course_ = course_;
	}
	
	public String getName() {
		return name_;
	}

	public void setName(String name) {
		this.name_ = name;
	}
	
	public Integer getCourse() {
		return course_;
	}


	public void setCourse(Integer course) {
		this.course_ = course;
	}


	public double getAverageGrade() {
		return avgGrade_;
	}


	public void setAverageGrade(double averageGrade) {
		this.avgGrade_ = averageGrade;
	}

	public List<Subject> getUncompletedSubjects() {
		for (int i = 0; i < sb_.size(); i++) {
			if(sb_.get(i).equals(null)) {
				unsb_.add(sb_.get(i));
			}
		}
		return unsb_;
	}

	public boolean addUncompletedSubject(Subject subject) {
		return unsb_.add(subject);
	}

	public boolean removeUncompletedSubject(Subject subject) {
		return unsb_.remove(subject) ;
	}
}
