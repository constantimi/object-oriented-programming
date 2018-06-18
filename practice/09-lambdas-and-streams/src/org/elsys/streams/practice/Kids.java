package org.elsys.streams.practice;

import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.stream.Collectors;

public class Kids {

    public static Set<String> getKidNames(List<Person> people) {
        Set<String> names = people.stream().filter(k -> k.getAge() < 18).map(k -> k.getName()).collect(Collectors.toSet());
    	return names;
    }

    public static Map<String, Integer> getKidsAgeByName(List<Person> people) {
        Map<String, Integer> age = people.stream().filter(k -> k.getAge() < 18).collect(Collectors.toMap(k -> k.getName(), k -> k.getAge(), (k1, k2) -> k1 ));
    	return age;
    }

}
