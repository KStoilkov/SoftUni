import java.util.Scanner;

public class _2_PythagoreanNumbers {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int n = reader.nextInt();
		int[] input = new int[n];
		for (int i = 0; i < n; i++) {
			input[i] = reader.nextInt();
		}
		
		boolean isFound = false;
		
		for (int i = 0; i < input.length; i++) {
			for (int j = 0; j < input.length; j++) {
				for (int k = 0; k < input.length; k++) {
					int a = input[i];
					int b = input[j];
					int c = input[k];
					if (a <= b) {
						if ((a * a) + (b * b) == (c * c)) {
							isFound = true;
							System.out.printf("%d*%d + %d*%d = %d*%d",a,a,b,b,c,c);
							System.out.println();
						}
					}
				}
			}
		}
		
		if (!isFound) {
			System.out.println("No");
		}
	}
}
