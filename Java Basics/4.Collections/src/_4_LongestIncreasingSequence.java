// Write a program to find all increasing sequences inside an array of integers. The integers are given in a single line, 
// separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. 
// Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. 
// If several sequences have the same longest length, print the leftmost of them. 

import java.util.Scanner;

public class _4_LongestIncreasingSequence {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		String numbers = reader.nextLine();
		String[] numbersArray = numbers.split(" ");
		
		int[] integers = new int[numbersArray.length];
		for (int i = 0; i < integers.length; i++) {
			integers[i] = Integer.parseInt(numbersArray[i]);
		}
		
		int maxCount = 0;
		int tempCount = 1;
		int maxEndIndex = 0;
		int tempEndIndex = 0;
		
		for (int i = 0; i < integers.length - 1; i++) {
			if (integers[i] < integers[i + 1]) {
				tempCount++;
				tempEndIndex = i + 1;
				if (i == integers.length - 2) {
					if (tempCount > maxCount) {
						maxCount = tempCount;
						maxEndIndex = tempEndIndex;
					}
					int startIndex = tempEndIndex - tempCount + 1;
					for (int j = startIndex; j <= tempEndIndex; j++) {
						System.out.print(integers[j] + " ");
					}
					System.out.println();
				}
			} else {
				if (tempCount > maxCount) {
					maxCount = tempCount;
					maxEndIndex = tempEndIndex;
				}
				int startIndex = tempEndIndex - tempCount + 1;
				for (int j = startIndex; j <= tempEndIndex; j++) {
					System.out.print(integers[j] + " ");
				}
				System.out.println();
				tempCount = 1;
				tempEndIndex = i + 1;
			}
		}
		
		int startIndex = maxEndIndex - maxCount + 1;
		System.out.print("Longest: ");
		for (int j = startIndex; j <= maxEndIndex; j++) {
			System.out.print(integers[j] + " ");
		}

	}


}