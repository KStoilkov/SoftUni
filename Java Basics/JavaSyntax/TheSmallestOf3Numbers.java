// Write a program that finds the smallest of three numbers. 

import java.util.Arrays;
import java.util.Scanner;

public class TheSmallestOf3Numbers {	
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		System.out.print("a: ");
		float a = reader.nextFloat();
		System.out.print("b: ");
		float b = reader.nextFloat();
		System.out.print("c: ");
		float c = reader.nextFloat();
		
		float[] smallest = new float[]{a , b , c};
		Arrays.sort(smallest);
		
		System.out.println(smallest[0]);
	}
}
