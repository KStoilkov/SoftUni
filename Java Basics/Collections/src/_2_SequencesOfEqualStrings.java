// Write a program that enters an array of strings and finds in it all sequences of equal elements. The input strings are given as a single line, separated by a space. 

import java.util.Scanner;

public class _2_SequencesOfEqualStrings {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String input = reader.nextLine();
		String[] n = input.split(" ");
		
		String temporary = n[0];
		
		for (int i = 0; i < n.length; i++) {
			if (temporary.equals(n[i])) {
				System.out.print(n[i] + " ");
			}
			else {
				temporary = n[i];
				i--;
				System.out.println();
			}
			
		}
	}
}
