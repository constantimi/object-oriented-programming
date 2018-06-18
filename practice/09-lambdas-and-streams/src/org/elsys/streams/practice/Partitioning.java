package org.elsys.streams.practice;

import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class Partitioning {
	
    public static Map<Boolean, List<Person>> partitionAdults(List<Person> people) {
        Map<Boolean, List<Person>> list = people.stream().collect(Collectors.partitioningBy(e -> e.getAge() > 18)); 
    	return list;
    }

}
