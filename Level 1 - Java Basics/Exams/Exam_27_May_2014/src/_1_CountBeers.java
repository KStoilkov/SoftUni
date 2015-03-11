import java.util.Scanner;

public class _1_CountBeers {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner reader = new Scanner(System.in);
		
		int beers = 0;
		
		while (true) {
			String n = reader.nextLine();
			if (n.equals("End")) {
				break;
			}
			String[] temp = n.split(" ");
			int parser = Integer.parseInt(temp[0]);
			if (temp[1].equals("stacks")) {
				beers += parser * 20;
			}
			else {
				beers += parser;
			}
		}
		System.out.printf("%d stacks + %d beers", beers/20 , beers%20);
	}
}
