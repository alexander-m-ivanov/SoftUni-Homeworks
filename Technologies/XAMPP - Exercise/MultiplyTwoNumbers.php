<!DOCTYPE >
<html>
    <head>
        <title>2. Multiply Two Numbers</title>
    </head>
    <body>
        <form>
            Number 1: <input type="text" name="num1" />
            Number 2: <input type="text" name="num2" />
            <input type="submit">
        </form>
        <?php
            if (isset($_GET['num1']) && isset($_GET['num2'])){
                $n1 = intval($_GET['num1']);
                $n2 = intval($_GET['num2']);
                echo $n1 * $n2;
            }
        ?>
    </body>
</html>