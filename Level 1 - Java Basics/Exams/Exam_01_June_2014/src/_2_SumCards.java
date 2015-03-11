import java.util.Scanner;


public class _2_SumCards {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String input = reader.nextLine();
		String[] splitted = input.split(" ");
		String[] cardF = new String[splitted.length];
		for (int i = 0; i < cardF.length; i++) {
			char temp = splitted[i].charAt(0);
			cardF[i] = String.valueOf(temp);
		}
		int[] cardValues = new int[cardF.length];
		for (int i = 0; i < cardValues.length; i++) {
			String current = cardF[i];
			switch (current) {
				case "2": cardValues[i] = 2;break;
				case "3": cardValues[i] = 3;break;
				case "4": cardValues[i] = 4;break;
				case "5": cardValues[i] = 5;break;
				case "6": cardValues[i] = 6;break;
				case "7": cardValues[i] = 7;break;
				case "8": cardValues[i] = 8;break;
				case "9": cardValues[i] = 9;break;
				case "1": cardValues[i] = 10;break;
				case "J": cardValues[i] = 12;break;
				case "Q": cardValues[i] = 13;break;
				case "K": cardValues[i] = 14;break;
				case "A": cardValues[i] = 15;break;
			}
		}
		
		int result = 0;
		boolean isFirst = true;
		
		
		for (int i = 0; i < cardValues.length; i++) {
			if (i == cardValues.length - 1) {
				if (cardValues[i] == cardValues[i - 1]) {
					result += cardValues[i] * 2;
				}
				else {
					result += cardValues[i];
				}
				break;
			}
			if (cardValues[i] == cardValues[i + 1]) {
				result += cardValues[i] * 2;
			}
			else {
				if (!isFirst) {
					if (cardValues[i] == cardValues[i - 1]) {
						result += cardValues[i] * 2;
					}
					else {
						result += cardValues[i];	
					}
				}
				else {
					result += cardValues[i];	
				}
				
			}
			isFirst = false;
		}
		System.out.println(result);
	}
}
