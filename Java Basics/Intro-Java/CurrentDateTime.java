// Create a simple Java program CurrentDateTime.java to print the current date and time. 
// Submit the Java class CurrentDateTime as part of your homework.

import java.time.LocalDateTime;

public class CurrentDateTime {
	public static void main(String[] args) {
		LocalDateTime current = LocalDateTime.now();
		System.out.println(current);		
	}
}
