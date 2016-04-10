package JavaSyntaxHomework;

import java.util.Scanner;

/*Problem 2.Triangle Area*/
public class Problem2 {
    public static void main(String[] args) {
        Scanner input = new Scanner (System.in);

        double xA = input.nextDouble();
        double yA = input.nextDouble();
        double xB = input.nextDouble();
        double yB = input.nextDouble();
        double xC = input.nextDouble();
        double yC = input.nextDouble();

        double area = (xA * (yB - yC) + xB * (yC - yA) + xC * (yA - yB)) / 2;

        if (area < 0) {
            System.out.printf("%.0f", area * -1);
        } else {
            System.out.printf("%.0f", area);
        }
    }
}
