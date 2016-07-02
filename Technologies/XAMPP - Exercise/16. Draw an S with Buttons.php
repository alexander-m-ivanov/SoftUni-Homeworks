<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <title>16. Draw an S with Buttons.</title>
        <link rel="stylesheet" type="text/css" href="styles.css">
    </head>
    <body>
        <?php
            for ($i = 1; $i <= 5; $i++) {       /*first line*/
                ?>
                <button class="line1">
                    <?php
                    echo 1;
                    ?>
                </button>
                <?php
            }
        ?>
        <br>
        <?php

            for ($i = 1; $i <= 3; $i++) {       /*top mid lines*/
                for ($j = 1; $j <= 5; $j++) {
                    if ($j == 1) {
                        ?>
                        <button class="topMidLines">
                            <?php
                            echo 1;
                            ?>
                        </button>
                        <?php
                    } else {
                        ?>
                        <button>
                            <?php
                            echo 1;
                            ?>
                        </button>
                        <?php
                    }
                }
                ?>
                <br>
                <?php
            }

        for ($i = 1; $i <= 5; $i++) {       /*mid line*/
            ?>
            <button class="line1">
                <?php
                echo 1;
                ?>
            </button>
            <?php
        }
        ?>
        <br>
        <?php

            for ($i = 1; $i <= 3; $i++) {       /*bottom mid lines*/
                for ($j = 1; $j <= 5; $j++) {
                    if ($j == 5) {
                        ?>
                        <button class="topMidLines">
                            <?php
                            echo 1;
                            ?>
                        </button>
                        <?php
                    } else {
                        ?>
                        <button>
                            <?php
                            echo 1;
                            ?>
                        </button>
                        <?php
                    }
                }
                ?>
                <br>
                <?php
            }

            for ($i = 1; $i <= 5; $i++) {       /*last/bot line*/
                ?>
                <button class="line1">
                    <?php
                    echo 1;
                    ?>
                </button>
                <?php
            }
        ?>
    </body>
</html>