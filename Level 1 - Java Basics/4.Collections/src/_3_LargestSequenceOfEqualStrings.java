// Write a program that enters an array of strings and finds in it the largest sequence of equal elements. 
// If several sequences have the same longest length, print the leftmost of them. The input strings are given as a single line, separated by a space. 

import java.util.Scanner;

public class _3_LargestSequenceOfEqualStrings {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		String text = reader.nextLine();
		String[] arrayOfStrings = text.split(" ");
				
		int tempCount = 1;
		int count = 0;
		int endIndex = 0;
		int tempEndIndex = 0;
		
		for (int i = 0; i < arrayOfStrings.length - 1; i++) {
			if (arrayOfStrings[i].equals(arrayOfStrings[i + 1])) {
				tempCount++;
				tempEndIndex = i + 1;
				if (i == arrayOfStrings.length - 2) {
					if (tempCount > count) {
						count = tempCount;
						endIndex = tempEndIndex;
					}
				}
			} else {
				if (tempCount > count) {
					count = tempCount;
					endIndex = tempEndIndex;
				}
				tempCount = 1;
			}
		}
		
		if (arrayOfStrings.length != 1) {
			int startIndex = endIndex - count + 1;
			for (int i = startIndex; i <= endIndex; i++) {
				System.out.print(arrayOfStrings[i] + " ");
			}
		} else {
			System.out.println(arrayOfStrings[0]);
		}

	}

}