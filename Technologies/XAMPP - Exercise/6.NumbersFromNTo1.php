<!DOCTYPE >
<html>
    <head>
        <title>6.Numbers from N to 1</title>
    </head>
    <body>
        <form>
            Number: <input type="text" name="num" />
            <input type="submit">
        </form>
        <?php
            if (isset($_GET['num'])) {
                $n1 = intval($_GET['num']);

                for ($i = $n1; $i >= 1; $i--){
                    echo $i . " ";
                }
            }
        ?>
    </body>
</html>