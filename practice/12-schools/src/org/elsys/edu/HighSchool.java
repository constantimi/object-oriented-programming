package org.elsys.edu;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Comparator;
import java.util.List;
import java.util.Map;
import java.util.function.Predicate;

public class HighSchool implements EducationalInstitution {
	
	private List<Student> std_ = new ArrayList<Student>();
	private List<Subject> sb_ = new ArrayList<Subject>();
	private String stdName_;
	private int year_;
	private double avgGrade_;
	
	public HighSchool(List<Student> std_, String stdName_, int year_, double avgGrade_) {
		super();
		this.std_ = std_;
		this.stdName_ = stdName_;
		this.year_ = year_;
		this.avgGrade_ = avgGrade_;
	}

	@Override
	public String getName() {
		return this.stdName_;
	}

	@Override
	public boolean signUpForNextYear(Student student) {
		int c = 0;
		foreach (Subject subject : sb_.getUncompletedSubjects()) {
			
		}
		if(std_.add(student)){
			return true;
		}

		return false; 
	}

	@Override
	public boolean signOut(Student student) {
		return std_.remove(student);
	}

	@Override
	public Collection<Student> getStudents() {
		return std_;
	}

	@Override
	public List<Student> getStudentsInCourse(int course, boolean orderedByAverageGrade) {
		List<Student> stdInCourse = new ArrayList<Student>();
		for (int i = 0; i < std_.size(); i++) {
			//if(course) {
				
			//}
		}
		return null;
	}

	@Override
	public List<Student> order(Comparator<Student> comparator) {
		List<Student> st = new ArrayList<Student>();
		//for (int i = 0; i < array.length; i++) {
			
		//}
		return null;
	}

	@Override
	public Collection<Student> filter(Predicate<Student> predicate) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Map<Integer, List<Student>> groupStudentsByGrade() {
		// TODO Auto-generated method stub
		return null;
	}

}
