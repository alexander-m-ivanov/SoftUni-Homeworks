package JavaSyntaxHomework;

import java.util.Scanner;

/*Problem 6.Convert from base-7 to decimal*/
public class Problem6 {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int n = input.nextInt();
        int a [] = new int[4];
        int counter = 0;
        int counter2 = a.length;
        int decimalResult = 0;

        while (n > 0) {
            a [counter] = n % 10;
            n /= 10;
            counter += 1;
        }

        for (int i = 0; i < counter; i++) {
            if (i == 0) {
                decimalResult = a[i];
            } else {
                decimalResult += (int)(a[i] * Math.pow(7, i));
            }
            counter2 -= 1;
        }
        System.out.println(decimalResult);
    }
}