// Write a program to check whether a point is inside or outside the house below. The point is given as a pair of floating-point numbers, 
// separated by a space. Your program should print "Inside" or "Outside". 

import java.util.Scanner;
public class _9_PointInsideHouse {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		
		Scanner reader = new Scanner(System.in);
		double x = reader.nextDouble();
		double y = reader.nextDouble();
		 
		double x1 = 12.5;
	    double y1 = 8.5;
		double x2 = 22.5;
		double y2 = 8.5;
		double x3 = 17.5;
		double y3 = 3.5;
		
		double ABC = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
		double ABP = x1 * (y2 - y) + x2 * (y - y1) + x * (y1 - y2);
		double APC = x1 * (y - y3) + x * (y3 - y1) + x3 * (y1 - y);
		double PBC = x * (y2 - y3) + x2 * (y3 - y) + x3 * (y - y2);
		
		boolean inRoof = ABP + APC + PBC == ABC;
		if (inRoof || ((x>=12.5 && x <= 17.5) && (y>=8.5 && y<=13.5)) || ((x>=20.0 && x <= 22.5) && (y>=8.5 && y<=13.5))) {
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}
		
	}
}
