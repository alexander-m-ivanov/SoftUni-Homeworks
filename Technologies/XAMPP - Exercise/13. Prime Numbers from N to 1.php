<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>13. Prime Numbers from N to 1</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num'])){
            $n = intval($_GET['num']);

            for ($i = $n; $i > 1; $i--){
                for ($j = $i - 1; $j > 1; $j--){
                    if ($i % $j == 0){
                        break;
                    } else if ($j == 2){
                        echo $i . " ";
                    }
                }
            }
        }
    ?>
</body>
</html>