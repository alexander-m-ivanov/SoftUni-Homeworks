<!DOCTYPE >
<html>
    <head>
        <title>Numbers 1 to 20</title>
        <style>
            div {
                display: inline-block;
                width: 120px;
                padding: 5px;
                margin: 5px;
            }
        </style>
    </head>
    <body>
        <ul>
            <?php
                for ($red = 0; $red <= 255; $red+= 51)
                    for ($green = 0; $green <= 255; $green+= 51)
                        for ($blue = 0; $blue <= 255; $blue+= 51){
                            $color = "rgb($red, $green, $blue)";
                            echo "<div style='background:$color'>$color</div>";
                        }
            ?>
        </ul>
    </body>
</html>