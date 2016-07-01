<!DOCTYPE >
<html>
    <head>
        <title>5. Numbers from 1 to N</title>
    </head>
    <body>
        <form>
            Number 1: <input type="text" name="num1" />
            <input type="submit">
        </form>
        <?php
            if (isset($_GET['num1'])) {
                $n1 = intval($_GET['num1']);

                for ($i = 1; $i <= $n1; $i++){
                    if ($i < $n1){
                        echo $i . " ";
                    } else if ($i > 1) {
                        echo $i;
                    }
                }
            }
        ?>
    </body>
</html>