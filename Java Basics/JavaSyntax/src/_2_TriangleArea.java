// Write a program that enters 3 points in the plane (as integer x and y coordinates), 
// calculates and prints the area of the triangle composed by these 3 points. Round the result to a whole number. 
// In case the three points do not form a triangle, print "0" as result. 

import java.util.Scanner;

public class _2_TriangleArea {	
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		//reading the points
		String firstTrianglePoint = reader.nextLine();
		String[] arr1 = firstTrianglePoint.split(" ");
		int aX = Integer.parseInt(arr1[0]);
		int aY = Integer.parseInt(arr1[1]);
		
		String secondTrianglePoint = reader.nextLine();
		String[] arr2 = secondTrianglePoint.split(" ");
		int bX = Integer.parseInt(arr2[0]);
		int bY = Integer.parseInt(arr2[1]);
		
		String thirdTrianglePoint = reader.nextLine();
		String[] arr3 = thirdTrianglePoint.split(" ");
		int cX = Integer.parseInt(arr3[0]);
		int cY = Integer.parseInt(arr3[1]);
				
		//calculating
		int triangleArea = (aX*(bY-cY) + bX*(cY-aY) + cX*(aY-bY))/2;
		
		if (triangleArea >= 0) {
			System.out.println(triangleArea);
		}
		else {
			System.out.println(triangleArea * -1);
		}
	}
} 
