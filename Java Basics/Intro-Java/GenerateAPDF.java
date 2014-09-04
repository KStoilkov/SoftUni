// Write a program to generate a PDF document called Deck-of-Cards.pdf 
// and print in it a standard deck of 52 cards, following one after another. 
// Each card should be a rectangle holding its face and suit.
import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Document;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Font;
import com.itextpdf.text.pdf.PdfWriter;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.BaseFont;

import java.io.FileOutputStream;

public class GenerateAPDF {
	public static void main(String[] args) {
		Document doc = new Document();
		try {
			PdfWriter.getInstance(doc, new FileOutputStream("Deck-of-Cards.pdf"));
			PdfPTable table = new PdfPTable(4);
			table.setWidthPercentage(70);
			table.getDefaultCell().setFixedHeight(120);

			BaseFont font = BaseFont.createFont("times.ttf", BaseFont.IDENTITY_H, true);
			Font black = new Font(font, 50f, 0, BaseColor.BLACK);
			Font red = new Font(font, 50f, 0, BaseColor.RED);
			doc.open();
			
				char[] suits = new char[]{'♠','♥','♣','♦'};
				String[] cardNums = new String[]{"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
				
				for (int i = 0; i < cardNums.length; i++) {
					for (int j = 0; j < 4; j++) {
						
						if (j == 0 || j == 2) {
							table.addCell(new Paragraph(cardNums[i] + suits[j], black));	
						}
						else {
							table.addCell(new Paragraph(cardNums[i] + suits[j], red));	
						} 
						
					}			
				}	
			doc.add(table);
			doc.close();
		}
		catch(Exception e){
			e.printStackTrace();
		}		
	}
}
