// Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
// Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, 
// padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after 
// the decimal point, left aligned. 

import java.util.Scanner;

public class _6_FormattingNumbers {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		System.out.print("a: ");
		int a = reader.nextInt();
		
		while (a < 0 || a > 500) {
			System.out.print("a: ");
			a = reader.nextInt();			
		}
		
		String aInHexa = Integer.toHexString(a).toUpperCase();
		String binaryA = Integer.toBinaryString(a);
		int aInBinary = Integer.parseInt(binaryA);
		System.out.print("b: ");
		float b = reader.nextFloat();
		System.out.print("c: ");
		float c = reader.nextFloat();
		
		System.out.printf("|%-10s|%010d|%10.2f|%-10.3f|", aInHexa , aInBinary, b , c);
	}
}
