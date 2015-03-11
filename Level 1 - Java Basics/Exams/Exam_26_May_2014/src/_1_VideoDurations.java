import java.util.Scanner;

public class _1_VideoDurations {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		int minutes = 0;
		
		while (true) {
			String input = reader.nextLine();
			if (input.contains("End")) {
				break;
			}
			String[] inputed = input.split(":");
			
			for (int i = 0; i < inputed.length; i += 2) {
				minutes += Integer.parseInt(inputed[i]) * 60;
				minutes += Integer.parseInt(inputed[i + 1]);
			}
		}
		
		System.out.printf("%d:%02d",minutes / 60, minutes % 60);
	}
}
