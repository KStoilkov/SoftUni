import java.util.ArrayList;
import java.util.Scanner;

public class _4_CouplesFrequency {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String n = reader.nextLine();
		String[] input = n.split(" ");
		
		int couplesCount = 0;
		
		for (int i = 0; i < input.length - 1; i++) {
			couplesCount++;
		}

		int occurrency = 0;
		
		ArrayList<String> tester = new ArrayList<>();
		
		for (int i = 0; i < input.length - 1; i++) {
			String couple = input[i] + " " + input[i + 1];
			if (!tester.contains(couple)) {
				for (int j = 0; j < input.length - 1; j++) {
					String couple2 = input[j] + " " + input[j + 1];
					if (couple.equals(couple2)) {
						occurrency++;
					}
				}
				
				int occ = occurrency * 100;
				double occu = (double)occ / (double)couplesCount;
				tester.add(couple);
				System.out.printf("%s -> %.2f" + "%%",couple,occu);
				System.out.println();
				occurrency = 0;
			}
		}

	}
}
