package org.elsys.streams.practice;

import java.util.List;

public class OldestPerson {

    public static Person getOldestPerson(List<Person> people) {
    	Person oldes = people.stream().max((p1, p2) -> p1.getAge() - p2.getAge()).get();
        return oldes;
    }

}
