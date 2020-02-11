package org.elsys.streams.practice;

import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class Grouping {

    public static Map<String, List<Person>> groupByNationality(List<Person> people) {
        Map<String, List<Person>> group = people.stream().collect(Collectors.groupingBy(Person::getNationality, Collectors.toList() ));
    	return group;
    }

    public static Map<String, List<String>> groupNamesByNationality(List<Person> people) {
        //Map<String, List<String>> groupNames = people.stream().collect(Collectors.groupingBy(Person::getNationality, Collectors.toMap(k -> k.getName(), k -> k.getAge(), (k1, k2) -> k1 ));
    	return null;
    }

}
