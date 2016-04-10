package com.company;

public class PrintCharacters {

    public static void main(String[] args) {
        for (int i = 97; i < 123; i++) {

            char a = (char)i;
            System.out.print(a);
            if (i == 122) {
                continue;
            }
            System.out.print(" ");
        }
    }
}
