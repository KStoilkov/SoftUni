// Write a program to calculate the count of bits 1 in the binary representation of given integer number n. 

import java.util.Scanner;

public class CountOfBitsOne {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int input = reader.nextInt();
		
		int onesCounter = 0;
		
		while (input > 0) {
			int bit = input & 1;
			if (bit == 1) {
				onesCounter++;
			}
			input >>= 1;
		}
		System.out.println(onesCounter);
	}
}
