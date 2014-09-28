// Write a program to generate and print all symmetric numbers in given range [start…end] (0 ≤ start ≤ end ≤ 999). 
// A number is symmetric if its digits are symmetric toward its middle. For example, the numbers 101, 33, 989 and 5 are symmetric, 
// but 102, 34 and 997 are not symmetric.

import java.util.Scanner;

public class _1_SymetricNumbers {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		System.out.print("start: ");
		int start = reader.nextInt();
		System.out.print("end: ");
		int end = reader.nextInt();
		
		while (0 > start || start > end || end > 999) {
			System.out.println("Invalid input.");
			System.out.print("start: ");
			start = reader.nextInt();
			System.out.print("end: ");
			end = reader.nextInt();
		}
		
		for (int i = start; i < end; i++) {
			if (i < 11) {
				System.out.print(i + " ");
			}
			else if (i > 11 && i < 100) {
				if (i % 10 == i / 10) {
					System.out.print(i + " ");
				}
			}
			else if (i > 100 && i < 1000) {
				if (i % 10 == i / 100) {
					System.out.print(i + " ");
				}
			}
		}
	}
}
