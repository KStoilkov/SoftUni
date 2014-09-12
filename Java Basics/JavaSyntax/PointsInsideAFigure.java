// Write a program to check whether a point is inside or outside of the figure below. 
// The point is given as a pair of floating-point numbers, separated by a space. 
// Your program should print "Inside" or "Outside". 

import java.util.Scanner;

public class PointsInsideAFigure {	
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String coord = reader.nextLine();
		String[] input = coord.split(" ");
		
		float x = Float.parseFloat(input[0]);
		float y = Float.parseFloat(input[1]);
		
		if (x >= 12.5 && x <= 22.5 && y >= 6.0 && y <= 13.5) {
			if (x >= 17.5 && x <= 20.0 && y >= 8.5 && y <= 13.5) {
				System.out.println("Outside");
			}
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
	}
}
