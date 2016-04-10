package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by ASUS on 20.03.2016 г..
 */
public class GhettoNumeralSystem {

    public static void main(String[] args) {

        Scanner input = new Scanner (System.in);
        int n = input.nextInt();
        String ghettoString = null;

        List<Integer> digits = new ArrayList<>();
        while (n > 0) {
            digits.add(n%10);
            n/=10;
        }

        for (int i = 0; i < digits.size(); i++) {

            switch (digits.get(digits.size() - i - 1)) {
                case 0: ghettoString = "Gee";
                    break;
                case 1: ghettoString = "Bro";
                    break;
                case 2: ghettoString = "Zuz";
                    break;
                case 3: ghettoString = "Ma";
                    break;
                case 4: ghettoString = "Duh";
                    break;
                case 5: ghettoString = "Yo";
                    break;
                case 6: ghettoString = "Dis";
                    break;
                case 7: ghettoString = "Hood";
                    break;
                case 8: ghettoString = "Jam";
                    break;
                case 9: ghettoString = "Mack";
                    break;
            }
            System.out.print(ghettoString);
        }
    }
}
