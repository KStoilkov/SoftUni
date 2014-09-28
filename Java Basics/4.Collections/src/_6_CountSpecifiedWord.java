// Write a program to find how many times a word appears in given text. The text is given at the first input line. 
// The target word is given at the second input line. The output is an integer number. Please ignore the character casing. 
// Consider that any non-letter character is a word separator. 

import java.util.Scanner;

public class _6_CountSpecifiedWord {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String input = reader.nextLine();
		String[] words = input.split("[^a-zA-Z]");
		String word = reader.next();
		
		int wordCounter = 0;
		
		for (int i = 0; i < words.length; i++) {
			if (words[i].contains(word)) {
				wordCounter++;
			}
		}
		System.out.println(wordCounter);
	}
}
