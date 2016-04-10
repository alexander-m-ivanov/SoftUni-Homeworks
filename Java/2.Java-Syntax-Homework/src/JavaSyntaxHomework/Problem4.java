package JavaSyntaxHomework;

import java.util.Locale;
import java.util.Scanner;
import static java.lang.Math.pow;
import static java.lang.StrictMath.abs;
import static java.lang.StrictMath.sqrt;

/*Problem 4.Calculate expression*/
public class Problem4 {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);

        Scanner input = new Scanner(System.in);

        float a = input.nextFloat();
        float b = input.nextFloat();
        float c = input.nextFloat();

        float formula1base = ((float) pow(a, 2) + (float) pow(b, 2))
                /
                ((float) pow(a, 2) - (float) pow(b, 2));
        float formula1= (float) pow(formula1base, ((a + b + c) / sqrt(c)));

        float formula2base = (float) pow(a, 2) + (float) pow(b, 2) - (float) pow(c, 3);
        float formula2 = (float) pow(formula2base, a - b);

        float averageABC = (a + b + c) / 3;
        float averageOfFormulas = (formula1 + formula2) / 2;
        float average = averageABC - averageOfFormulas;

        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", formula1, formula2, abs(average));
    }
}