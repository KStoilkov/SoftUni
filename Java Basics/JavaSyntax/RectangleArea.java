// Write a program that enters the sides of a rectangle (two integers a and b) 
// and calculates and prints the rectangle's area.
import java.util.Scanner;
public class RectangleArea {
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		int a = reader.nextInt();
		int b = reader.nextInt();
		
		int area = a * b;
		System.out.println(area);
		reader.close();
	}
}
