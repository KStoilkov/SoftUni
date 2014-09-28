// Write a program to count the number of words in given sentence. Use any non-letter character as word separator.

import java.util.Scanner;

public class _5_CountAllWords {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		String input = reader.nextLine();
		String[] words = input.split("[^a-zA-Z]");
		
		System.out.println(words.length);
	}
}
