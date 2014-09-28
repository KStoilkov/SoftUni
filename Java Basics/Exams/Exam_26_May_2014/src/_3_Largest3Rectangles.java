import java.util.Scanner;


public class _3_Largest3Rectangles {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String input = reader.nextLine();
		String[] inputed = input.split("[^0-9]+");
		
		int[] intInputed = new int[inputed.length - 1];
		
		for (int i = 0; i < inputed.length; i++) {
			if (inputed[i].equals("")) {
				continue;
			}
			intInputed[i - 1] = Integer.parseInt(inputed[i]);
		}
		
		int bestLR = 0;
		
		for (int i = 0; i < intInputed.length - 4; i+=2) {
			int firstRect = intInputed[i] * intInputed[i + 1];
			int secondRect = intInputed[i + 2] * intInputed[i + 3];
			int thirdRect = intInputed[i + 4] * intInputed[i + 5];
			int currentLR = firstRect + secondRect + thirdRect;
			if (currentLR > bestLR) {
				bestLR = currentLR;
			}
		}
	
		System.out.println(bestLR);
	}
}
