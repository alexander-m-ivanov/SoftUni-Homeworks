<!DOCTYPE >
<html>
    <head>
        <title>4. Product of 3 Numbers</title>
    </head>
    <body>
    <form>
        Number 1: <input type="text" name="num1" />
        Number 2: <input type="text" name="num2" />
        Number 3: <input type="text" name="num3" />
        <input type="submit">
    </form>
    <?php
        if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])){
            $n1 = intval($_GET['num1']);
            $n2 = intval($_GET['num2']);
            $n3 = intval($_GET['num3']);

            /*Case	$n1	$n2	$n3	product
                1	+	+	+	+
                2	-	+	+	-
                3	+	-	+	-
                4	+	+	-	-
                5	-	-	+	+
                6	-	+	-	+
                7	+	-	-	+
                8	-	-	-	-
                9   0   0   0   +*/

            $isNegative2 = ($n1 < 0) && ($n2 >= 0) && ($n3 >= 0);
            $isNegative3 = ($n1 >= 0) && ($n2 < 0) && ($n3 >= 0);
            $isNegative4 = ($n1 >= 0) && ($n2 >= 0) && ($n3 < 0);
            $isNegative8 = ($n1 < 0) && ($n2 < 0) && ($n3 < 0);

            if (($n1 == 0) || ($n2 == 0) || ($n3 == 0)){
                echo "Positive";
            } else if ($isNegative2 || $isNegative3 || $isNegative4 || $isNegative8){
                echo "Negative";
            } else {
                echo "Positive";
            }
        }
        ?>
    </body>
</html>