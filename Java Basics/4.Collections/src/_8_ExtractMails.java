// Write a program to extract all email addresses from given text. The text comes at the first input line. 
// Print the emails in the output, each at a separate line. 

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _8_ExtractMails {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		String text = reader.nextLine();
		
		Pattern emailPattern = Pattern.compile("[\\w]+[\\.-]*[\\w]+@[A-Za-z-]+-*[A-Za-z]\\.[A-Za-z]+\\.*[A-Za-z]+");
		Matcher matcher = emailPattern.matcher(text);
		
		while (matcher.find()) {
			System.out.println(matcher.group());
		}
	}
}
