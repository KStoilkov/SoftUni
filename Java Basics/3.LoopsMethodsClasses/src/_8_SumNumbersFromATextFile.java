// Write a program to read a text file "Input.txt" holding a sequence of integer numbers, each at a separate line. 
// Print the sum of the numbers at the console. Ensure you close correctly the file in case of exception or in case of normal execution. 
// In case of exception (e.g. the file is missing), print "Error" as a result. 

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class _8_SumNumbersFromATextFile {
    public static void main(String[] args) {

        BufferedReader reader;

        double sum = 0;

        try {
            reader = new BufferedReader(new FileReader("Input8.txt"));
            String line = null;

            while ((line = reader.readLine()) != null) {
                sum += Double.parseDouble(line);
            }
            reader.close();
            System.out.println(sum);
        }

        catch (FileNotFoundException notFound) {
            System.out.println("File not found");
        }

        catch (IOException err) {
            System.out.println("Error" + err.getMessage());
        }
    }
 }