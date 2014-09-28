// We are given a sequence of N playing cards from a standard deck. The input consists of several cards (face + suit), separated by a space. 
// Write a program to calculate and print at the console the frequency of each card face in format "card_face -> frequency". 
// The frequency is calculated by the formula appearances / N and is expressed in percentages with exactly 2 digits after the decimal point. 
// The card faces with their frequency should be printed in the order of the card face's first appearance in the input. 
// The same card can appear multiple times in the input, but it's face should be listed only once in the output. 

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class _12_CardsFrequencies {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner reader = new Scanner(System.in);
		
		String[] input = reader.nextLine().split("\\W+");
		
		LinkedHashMap<String, Integer> cards = new LinkedHashMap<>();
		int totalCount = 0;
		
		for (String word : input) {
			  Integer count = cards.get(word);
			  if (count == null) {
			    count = 0; 
			  }
			  cards.put(word, count+1);
			  totalCount++;
		}
		
		for (Map.Entry<String, Integer> entry : cards.entrySet()) {
			double currentPercentage = ((double)entry.getValue() / (double)totalCount) * 100;
			
			System.out.print(entry.getKey() + " -> ");
			System.out.printf("%.2f", currentPercentage);
			System.out.println(" %");
		}
	}
}
