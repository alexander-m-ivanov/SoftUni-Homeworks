package JavaSyntaxHomework;

import java.util.Scanner;

/*Problem 5.Convert from decimal system to base-7*/
public class Problem5 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int n = input.nextInt();
        int storeResultPowers [] = new int[10];
        int storeDecimalDigits [] = new int[10];
        int counter = 0;
        int counter2 = 0;
        int BiggestResultPowers = 0;

        while (BiggestResultPowers < n) {
            storeResultPowers [counter] = (int)Math.pow(7, counter);
            BiggestResultPowers = storeResultPowers [counter];
            counter += 1;
            counter2 += 1;
        }

        if (n > 7) {
            for (int i = 0; i < counter - 1; i++) {
                storeDecimalDigits[i] = n / storeResultPowers[counter2 - 2];
                n %= storeResultPowers[counter2 - 2];
                counter2 -= 1;
                System.out.print(storeDecimalDigits[i]);
            }
        } else if (n == 7){
            System.out.print(10);
        } else if (n < 7) {
            System.out.print(n);
        }

        System.out.println();
    }
}