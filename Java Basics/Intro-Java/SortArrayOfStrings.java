// Write a program that enters from the console number n 
// and n strings, then sorts them alphabetically and prints them.

import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfStrings {
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int arraySize = reader.nextInt();
		String[] theArray = new String[arraySize];
		
		for (int i = 0; i < theArray.length; i++) {
			theArray[i] = reader.nextLine();
		}
		reader.close();
		Arrays.sort(theArray);
		
		for (int i = 0; i < theArray.length; i++) {
			System.out.println(theArray[i]);
		}
		
	}
}
