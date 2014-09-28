// Write a method to convert from degrees to radians. Write a method to convert from radians to degrees. 
// You are given a number n and n queries for conversion. Each conversion query will consist of a number + space + measure. 
// Measures are "deg" and "rad". Convert all radians to degrees and all degrees to radians. Print the results as n lines, 
// each holding a number + space + measure. Format all numbers with 6 digit after the decimal point. 


import java.util.Scanner;

public class _5_AngleUnitConverter {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int input = reader.nextInt();
		reader.nextLine();
		
		for (int i = 0; i < input; i++) {
			String secInput = reader.nextLine();
			String[] splitted = secInput.split(" ");	
			if (splitted[1].equals("rad")) {
				double degrees = radToDeg(splitted[0]);
				System.out.printf("%.6f deg",degrees);
				System.out.println();
			}
			else if (splitted[1].equals("deg")) {
				double radians = degToRad(splitted[0]);
				System.out.printf("%.6f rad",radians);
				System.out.println();
			}
		}
		
	}
	
	private static double degToRad(String deg){
		double degrees = Double.parseDouble(deg);
		double rad = degrees * (Math.PI / 180);
		return rad;
	}
	
	private static double radToDeg(String rad){
		double radians = Double.parseDouble(rad);
		double deg = radians * (180 / Math.PI);
		return deg;
	}
}
