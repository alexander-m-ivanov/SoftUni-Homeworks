<!DOCTYPE >
<html>
    <head>
        <title>Dump a HTTP GET Request</title>
    </head>
    <body>
        <?php
            if (isset($_GET['num1']) && isset($_GET['num2'])) {
                $num1 = $_GET['num1'];
                $num2 = $_GET['num2'];
                $sum = $num1 + $num2;
                echo $num1 . " + " . $num2 . " = " . $sum;
            }
        ?>
        <form>
            <div>Num 1:</div><input type="number" name="num1" />
            <div>Num 2:</div><input type="number" name="num2" />
            <div><input type="submit" value="calculate"></div>
        </form>
    </body>
</html>