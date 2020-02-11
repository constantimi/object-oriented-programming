package org.elsys.streams.practice;

import java.util.List;
import java.util.stream.Collectors;

public class FlatCollection {

    public static List<String> transform(List<List<String>> collection) {
    	List<String> list = collection.stream().flatMap(c -> c.stream()).collect(Collectors.toList());
        return list;
    }

}
