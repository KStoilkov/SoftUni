// Write a program to calculate the difference between two dates in number of days. 
// The dates are entered at two consecutive lines in format day-month-year. Days are in range [1…31]. 
// Months are in range [1…12]. Years are in range [1900…2100].

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;


public class _7_DaysBetweenTwoDays {

	@SuppressWarnings("resource")
	public static void main(String[] args) throws ParseException {
		Scanner input = new Scanner(System.in);
		String firstDateString = input.nextLine();
		String secondDateString = input.nextLine();
		
		SimpleDateFormat pattern = new SimpleDateFormat("dd-MM-yyyy");
		Date firstDate = pattern.parse(firstDateString);
		Date secondDate = pattern.parse(secondDateString);
		
		long diff = secondDate.getTime() - firstDate.getTime();
		long diffDays = diff / (24 * 60 * 60 * 1000);
		System.out.println(diffDays);

	}

}