<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <title>17. RGB Table</title>
        <style>
            table * {
                border: 1px solid black;
                width: 50px;
                height: 50px;
            }
        </style>
    </head>
    <body>
        <table>
            <tr>
                <td>
                    Red
                </td>
                <td>
                    Green
                </td>
                <td>
                    Blue
                </td>
            </tr>
            <?php
                $colorShade = 51;
                for ($row = 1; $row <= 5; $row++){
                    for ($col = 1; $col <= 3; $col++){
                        if ($col == 1){
                            $space = "<br>";
                            $color = "style='background-color:rgb(" . $colorShade * $row . ",0,0)'";
                            $cell = "<tr><td $color></td>";
                            echo $cell;
                        } else if ($col == 2){
                            $color = "style='background-color:rgb(0," . $colorShade * $row . ",0)'";
                            $cell = "<td $color></td>";
                            echo $cell;
                        } else if ($col == 3) {
                            $color = "style='background-color:rgb(0,0," . $colorShade * $row . ")'";
                            $cell = "<td $color></td></tr>";
                            echo $cell;
                        }
                    }
                }
            ?>
        </table>
    </body>
</html>