package org.elsys.streams.practice;

import java.util.List;

public class Sum {

    public static int calculate(List<Integer> people) {
        int sum = people.stream().mapToInt(i -> i.intValue()).sum();
    	return sum;
    }

}
