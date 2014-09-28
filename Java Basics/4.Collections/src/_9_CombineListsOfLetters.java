// Write a program that reads two lists of letters l1 and l2 and combines them: appends all letters c from l2 to the end of l1, 
// but only when c does not appear in l1. Print the obtained combined list. All lists are given as sequence of letters separated by a single space, 
// each at a separate line. Use ArrayList<Character> of chars to keep the input and output lists. 

import java.util.ArrayList;
import java.util.Scanner;

public class _9_CombineListsOfLetters {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner reader = new Scanner(System.in);
		
		ArrayList<String> letterGroup = new ArrayList<>();
		ArrayList<String> firstGroup = new ArrayList<>();
		
		String[] input1 = reader.nextLine().split(" ");
		
		
		for (String letter : input1) {
			letterGroup.add(letter);
			firstGroup.add(letter);
		}
		
		String[] input2 = reader.nextLine().split(" ");
		
		for (String letter : input2) {
			if (!firstGroup.contains(letter)) {
				letterGroup.add(letter);
			}
		}
		
		for (String letter : letterGroup) {
			System.out.print(letter + " ");
		}
	}
}
