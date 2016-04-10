package com.company;

import java.util.Scanner;

public class PrintACharacterTriangle {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int i = input.nextInt();
        int counter = i;

        for (int j = 0; j < i; j++) {

            counter = counter - 1;

            for (int k = 0; k < i - counter; k++) {
                char[] letter = Character.toChars (k + 97);
                System.out.print (letter[0]);
                if (k == i - counter - 1) {
                    continue;
                }
                System.out.print (" ");
            }
            System.out.println ();
        }
        for (int l = 0; l < i; l++) {

            counter = counter + 1;

            for (int k = 0; k < i - counter; k++) {
                char[] letter = Character.toChars (k + 97);
                System.out.print (letter[0]);
                if (k == i - counter - 1) {
                    continue;
                }
                System.out.print (" ");
            }
            if (l == i - 1) {
                continue;
            }
            System.out.println ();
        }
    }
}
