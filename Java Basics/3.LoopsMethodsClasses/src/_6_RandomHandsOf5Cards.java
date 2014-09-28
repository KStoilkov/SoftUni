// Write a program to generate n random hands of 5 different cards form a standard suit of 52 cards. 

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class _6_RandomHandsOf5Cards {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		
		Scanner reader = new Scanner(System.in);
		
		int n = reader.nextInt();
		
		String[] cardNums = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		
		String[] cardSuits = {"♣", "♦", "♥", "♠"};
		
		ArrayList<String> allCards = new ArrayList<String>();

		for (int i = 0; i < cardNums.length; i++) {
			for (int j = 0; j < cardSuits.length; j++) {
				allCards.add(cardNums[i] + cardSuits[j]);
			}
		}
		
		String[] cards = allCards.toArray(new String[allCards.size()]);
		
		ArrayList<String> result = new ArrayList<String>();
		
		Random generator = new Random();
		
		int counter = 1;
		
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < 5; j++) {

				int randomElement = generator.nextInt(cards.length);
				if (!result.contains(cards[randomElement])) {
					result.add(cards[randomElement]);
				}
				else {
					j--;
				}
			}
			for (String playCards : result) {
				System.out.print(playCards + " ");
				if (counter % 5 == 0) {
					System.out.println();
				}
				counter++;
			}
			result.removeAll(result);
		}	
	}
}
