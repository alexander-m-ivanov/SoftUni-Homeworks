package JavaSyntaxHomework;

import java.util.Locale;
import java.util.Scanner;

/*Problem 3.Formatting Numbers*/
public class Problem3 {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);

        Scanner input = new Scanner (System.in);

        int a = input.nextInt();
        float b = input.nextFloat();
        float c = input.nextFloat();

        System.out.printf("|%-10X|", a);

        String aBinery = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
        System.out.printf(aBinery);

        System.out.printf("|%10.2f|%-10.3f|", b, c);
    }
}
