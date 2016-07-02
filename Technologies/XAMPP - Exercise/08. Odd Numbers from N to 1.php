<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <title>8. Odd Numbers from N to 1</title>
    </head>
    <body>
        <form>
            N: <input type="text" name="num" />
            <input type="submit" />
        </form>
        <?php
            if (isset($_GET['num'])){
                $n = intval($_GET['num']);

                for ($i = $n; $i >= 1; $i--){
                    if ($i % 2 == 1){
                        echo $i . " ";
                    }
                }
            }
        ?>
    </body>
</html>