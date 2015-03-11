import java.util.ArrayList;
import java.util.Scanner;


public class _3_ValidUsernames {
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		
		String input = reader.nextLine();
		
		String[] usernames = input.split("[^a-zA-Z0-9_]+");
		
		ArrayList<String> validUsernames = new ArrayList<String>();
		
		for (int i = 0; i < usernames.length; i++) {
			if (usernames[i].length() >= 3 && usernames[i].length() <= 25) {
				if (usernames[i].charAt(0) >= 'A' && usernames[i].charAt(0) <= 'Z' || usernames[i].charAt(0) >= 'a' && usernames[i].charAt(0) <= 'z') {
					validUsernames.add(usernames[i]);
				}
			}
		}
		
		String[] validUsers = new String[validUsernames.size()];
		
		validUsers = validUsernames.toArray(validUsers);
		
		int bestSum = 0;
		int pos1 = 0;
		int pos2 = 0;
		for (int i = 0; i < validUsers.length; i++) {
			for (int j = i + 1; j < validUsers.length; j++,i++) {
				int currentSum = validUsers[i].length() + validUsers[j].length();
				if (currentSum > bestSum) {
					pos1 = i;
					pos2 = j;
					bestSum = currentSum;
				}
			}
		}
		
		System.out.println(validUsers[pos1]);
		System.out.println(validUsers[pos2]);
	}
}
