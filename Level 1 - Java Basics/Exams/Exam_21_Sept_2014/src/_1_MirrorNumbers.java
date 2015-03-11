import java.util.Scanner;

public class _1_MirrorNumbers {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int n = reader.nextInt();
		
		int[] input = new int[n];
		for (int i = 0; i < input.length; i++) {
			input[i] = reader.nextInt();
		}
		
		boolean isFound = false;
		
		for (int i = 0; i < input.length; i++) {
			for (int j = i + 1; j < input.length; j++) {
				if (input[i] / 1000 == input[j] % 10) {
					if ((input[i] % 1000) / 100 == (input[j] % 100) / 10) {
						if ((input[i] % 100) / 10 == (input[j] % 1000) / 100) {
							if (input[i] % 10 == input[j] / 1000) {
								isFound = true;
								System.out.println(input[i] + "<!>" + input[j]);
							}
						}
					}
					
				}
			}
		}
		if (isFound == false) {
			System.out.println("No");
		}
	}
}
