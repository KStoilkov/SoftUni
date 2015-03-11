import java.util.ArrayList;
import java.util.Scanner;


public class _2_PossibleTriangles {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
			
		ArrayList<String> inputHolder = new ArrayList<String>();
		while (true) {	
			String input = reader.nextLine();
			String[] sec = input.split(" ");
			if (input.contains("End")) {
				break;
			}
			for (int i = 0; i < sec.length; i++) {
				inputHolder.add(sec[i]);
			}			
		}
		
		String[] inputed = new String[inputHolder.size()];
		inputed = inputHolder.toArray(inputed);
		
		double[] nums = new double[inputed.length];
		
		for (int i = 0; i < inputed.length; i++) {
			nums[i] = Double.parseDouble(inputed[i]);		
		} 
		
		boolean isFound = false;
		
		for (int i = 0; i < nums.length; i += 3) {
			double a = nums[i];
			double b = nums[i + 1];
			double c = nums[i + 2];
			if (a < c && b < c && a + b > c) { 
				isFound = true;
				if (a > b) {
					System.out.printf("%.2f+%.2f>%.2f",b,a,c);
				} 
				else 
				{
					System.out.printf("%.2f+%.2f>%.2f",a,b,c);	
				}
				System.out.println();
			}
			if (a < b && c < b && a + c > b) {
				isFound = true;
				if (a > c) {
					System.out.printf("%.2f+%.2f>%.2f",c,a,b);
				}
				else 
				{
					System.out.printf("%.2f+%.2f>%.2f",a,c,b);
				}
				System.out.println();
			}
			if (b < a && c < a && b + c > a) {
				isFound = true;
				if (b > c) {
					System.out.printf("%.2f+%.2f>%f.2",c,b,a);	
				}
				else 
				{
					System.out.printf("%.2f+%.2f>%f.2",b,c,a);	
				}
				System.out.println();
			}
		}
		if (isFound == false) {
			System.out.println("No");
		}
		
	
	}
}
