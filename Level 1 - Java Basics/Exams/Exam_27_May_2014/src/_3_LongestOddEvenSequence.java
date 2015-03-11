import java.util.Scanner;

public class _3_LongestOddEvenSequence {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String input = reader.nextLine();
		String[] inputed = input.split("[^0-9]+");
		
		int[] nums = new int[inputed.length - 1];
		
		for (int i = 0; i < inputed.length; i++) {
			if (inputed[i].equals("")) {
				continue;
			}
			nums[i - 1] = Integer.parseInt(inputed[i]);
		}
		
		int bestLenght = 0;	
		int currentLenght = 0;
		
		boolean isEven = nums[0] % 2 == 0; 
		
		for (int i = 0; i < nums.length; i++) {
			boolean isItEven = nums[i] % 2 == 0;
			
			if (isItEven == isEven || nums[i] == 0) {
				currentLenght++;
			}
			else {
				isEven = isItEven;
				currentLenght = 1;
			}
			
			isEven = !isEven;
			
			if (currentLenght > bestLenght) {
				bestLenght = currentLenght;
			}
		}
		System.out.println(bestLenght);
		
		
	}
}
