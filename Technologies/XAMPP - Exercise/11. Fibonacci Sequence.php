<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <title>11. Fibonacci Sequence</title>

    </head>
    <body>
        <form>
            N: <input type="text" name="num" />
            <input type="submit" />
        </form>
        <?php
            if (isset($_GET['num'])){
                $n = intval($_GET['num']);
                $fibNum1 = 0;
                $fibNum2 = 1;

                for ($i = 1 ; $i <= $n; $i++){
                    if ($i == 1){
                        echo 1 . " ";
                    } else if ($i == $n) {
                        $result = $fibNum1 + $fibNum2;
                        echo $result;
                        $fibNum1 = $fibNum2;
                        $fibNum2 = $result;
                    } else {
                        $result = $fibNum1 + $fibNum2;
                        echo $result . " ";
                        $fibNum1 = $fibNum2;
                        $fibNum2 = $result;
                    }
                }
            }
        ?>
    </body>
</html>