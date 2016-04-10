package com.company;

import java.util.Scanner;

public class SumNumbersFrom1toN {

    public static void main(String[] args) {

        Scanner input = new Scanner (System.in);
        int n = input.nextInt();
        int staticN = n;
        int sum = 0;

        if (n != 1) {
            for (int i = 0; i < staticN; i++) {
                n -= 1;
                sum += n;
            }
            sum += staticN;
            System.out.println(sum);
        } else {
            System.out.println(1);
        }
    }
}
