package elsys;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class Name {
	private String firstName;
	private String lastName;
	
	public Name(String firstName, String lastName) {
		this.firstName = firstName;
		this.lastName = lastName;
	}
	
	public String getfirstName() {
		return firstName;
	}
	
	public String getlastName() {
		return lastName;
	}
	
	@Override 
	public boolean equals(Object other) {
		Name A = (Name) other;
		return firstName.equals(A.firstName) && lastName.equals(A.lastName);
	}
	
	@Override
	public int hashCode() {
		return firstName.hashCode() + lastName.hashCode();
	}
	public static void main(String[] args) {
		Name a1 = new Name("Pesho", "Peshev");
		Name a2 = new Name("Ivan", "Ivanov");
		
		List<Name> names = new ArrayList<Name>();
		
		names.add(a1);
		names.add(a2);
		
		System.out.println(names.contains(a1));
		System.out.println(names.contains(a2));
		
		System.out.println(names.contains(
				new Name("Ivancho","Ivanov")));
		System.out.println(names.contains(
				new Name("Ivan", "Ivanov")));
		
		Name a3 = new Name("Ivan", "Ivanov");
		Name a4 = a3;
		
		System.out.println(" 1 ==  1 -> " + (1 == 1));
		System.out.println("a2 == a3 -> " + (a2 == a3));
		System.out.println("a3 == a4 -> " + (a3 == a4));
		// method equals to Class Object
		System.out.println("a2.equals(a3) -> " + (a2.equals(a3)));
	
		
		Set<Name> namesSet = new HashSet<Name>();
		namesSet.add(a1);
		namesSet.add(a2);
		
		System.out.println(namesSet.contains(a1));
		System.out.println(namesSet.contains(a2));
		System.out.println(namesSet.contains(a3));
		
		//What's hash code?
		System.out.println("ala bala".hashCode());
		System.out.println("ala bala code".hashCode());
	}

}
