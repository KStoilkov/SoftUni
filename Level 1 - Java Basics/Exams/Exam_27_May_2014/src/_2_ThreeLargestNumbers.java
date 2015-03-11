import java.math.BigDecimal;
import java.util.Arrays;
import java.util.Scanner;

public class _2_ThreeLargestNumbers {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int n = reader.nextInt();
	
		BigDecimal[] input = new BigDecimal[n];
		for (int i = 0; i < input.length; i++) {
			input[i] = reader.nextBigDecimal();
		}
		
		Arrays.sort(input);
		
		if (input.length >= 3) {
			for (int i = input.length - 1; i > input.length - 4; i--) {
				System.out.println(input[i].toPlainString());
			}
		}
		else {
			for (int i = input.length - 1; i >= 0; i--) {
				System.out.println(input[i].toPlainString());
			}
		}
		
		

	}
}
