import java.util.Scanner;

public class _1_StuckNumbers {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int n = reader.nextInt();
		int[] input = new int[n];
		for (int i = 0; i < input.length; i++) {
			input[i] = reader.nextInt();
		}
		
		boolean isFound = false;
		
		for (int first = 0; first < input.length; first++) {
			for (int second = 0; second < input.length; second++) {
				for (int third = 0; third < input.length; third++) {
					for (int forth = 0; forth < input.length; forth++) {
						int a = input[first];
						int b = input[second];
						int c = input[third];
						int d = input[forth];
						
						if (a != b && a != c && a != d && b != c && b != d && c != d) {
							String part1 = "" + a + b;
							String part2 = "" + c + d;
							if (part1.equals(part2)) {
								System.out.printf("%d|%d==%d|%d",a,b,c,d);
								System.out.println();
								isFound = true;
							}
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
