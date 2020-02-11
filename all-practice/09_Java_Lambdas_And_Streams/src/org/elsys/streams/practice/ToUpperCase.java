package org.elsys.streams.practice;

import java.util.List;
import java.util.stream.Collectors;

public class ToUpperCase {

    public static List<String> transform(List<String> collection) {
    	List<String> upped = collection.stream().map(String::toUpperCase).collect(Collectors.toList());
    	return upped;
    }

}
