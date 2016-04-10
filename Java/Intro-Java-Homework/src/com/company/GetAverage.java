package com.company;

import java.util.Locale;
import java.util.Scanner;

/**
 * Created by ASUS on 20.03.2016 г..
 */
public class GetAverage {

    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);

        Scanner input1 = new Scanner(System.in);
        float n1 = input1.nextFloat();
        float n2 = input1.nextFloat();
        float n3 = input1.nextFloat();
        float average1 = getAnAverageOutOf3(n1, n2, n3);
        System.out.printf("%.2f", average1);
    }

    public static float getAnAverageOutOf3(float input1,  float input2, float input3) {
        float sum = input1 + input2 + input3;
        float average = sum / 3;
        return average;
    }
}


