// Write a program to find the most frequent word in a text and print it, as well as how many times it appears in format "word -> count". 
// Consider any non-letter character as a word separator. Ignore the character casing. If several words have the same maximal frequency, 
// print all of them in alphabetical order.

import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class _11_MostFrequendWords {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner reader = new Scanner(System.in);
		
		String[] input = reader.nextLine().toLowerCase().split("\\W+");
		
		TreeMap<String, Integer> wordsCount = new TreeMap<>();
		
		for (String word : input) {
			  Integer count = wordsCount.get(word);
			  if (count == null) {
			    count = 0; 
			  }
			  wordsCount.put(word, count+1);
		}
		
		int largestCount = 0;
		
		for (Object value : wordsCount.values()) {
			if (largestCount < (Integer)value) {
				largestCount = (Integer)value;
			}
		}
		
		for (Map.Entry<String, Integer> entry : wordsCount.entrySet()) {
			
			if (entry.getValue() == largestCount) {
				System.out.println(entry.getKey() + " -> " + entry.getValue());
			}
		}
	}
}
