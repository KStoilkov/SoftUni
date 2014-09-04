// Write a program SumTwoNumbers.java that enters two integers from the console, calculates and prints their sum. 
// Search in Internet to learn how to read numbers from the console.

import java.util.Scanner;

public class SumTwoNumbers {
	public static void main(String[] args) {
		
		Scanner reader = new Scanner(System.in);
		
		System.out.println("1st number: ");
		int first = reader.nextInt();
		System.out.println("2nd number: ");
		int second = reader.nextInt();
		System.out.println("result: ");
		int sum = first + second;
		reader.close();
		System.out.println(sum);
	}
}
