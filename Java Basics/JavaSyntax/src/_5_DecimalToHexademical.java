// Write a program that enters a positive integer number num and converts and prints it in hexadecimal form. 
// You may use some built-in method from the standard Java libraries

import java.util.Scanner;

public class _5_DecimalToHexademical {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int input = reader.nextInt();
		
		String toHexa = Integer.toHexString(input).toUpperCase();
			
		System.out.println(toHexa);
	}
}
