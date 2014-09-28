// Write a program to enter a number n and n integer numbers and sort and print them. Keep the numbers in array of integers: int[]. 

import java.util.Arrays;
import java.util.Scanner;

public class _1_SortArrayOfNumbers {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int input = reader.nextInt();
		
		int[] n = new int[input];
		for (int i = 0; i < n.length; i++) {
			n[i] = reader.nextInt();
		}
		
		Arrays.sort(n);
		
		for (int i = 0; i < n.length; i++) {
		System.out.print(n[i] + " ");	
		}
	}
}
