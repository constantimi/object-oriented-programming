package org.elsys.edu;

import java.util.ArrayList;
import java.util.List;

public class Subject {

	private boolean m_;
	private String sbname_;
	
	public String getName() {
		return sbname_;
	}

	public void setName(String name) {
		this.sbname_ = name;
	}

	public boolean isMandatory() {
		return m_;
	}

	public void setMandatory(boolean mandatory) {
       this.m_ = mandatory;
	}
	
}
