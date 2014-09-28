// Write a program to generate and print all 3-letter words consisting of given set of characters. For example if we have the characters 'a' and 'b', 
// all possible words will be "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and "bbb". The input characters are given as string at the first line of the input. 
// Input characters are unique (there are no repeating characters). 

import java.util.Scanner;

public class _2_Generate3LettersWord {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String input = reader.nextLine();
		
		while (input.length() > 3) {
			System.out.println("Invalid Input! Try again:");
			input = reader.nextLine();
		}
		
		char[] letters = input.toCharArray();
		
		int counter = 1;
		for (int i = 0; i < letters.length; i++) {
			for (int j = 0; j < letters.length; j++) {
				for (int g = 0; g < letters.length; g++) {
					System.out.printf("%d.%s%s%s",counter,letters[i],letters[j],letters[g]);
					System.out.println();
					counter++;
				}
			}		
		}
	}
}
