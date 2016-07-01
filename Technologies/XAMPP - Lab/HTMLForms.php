<!DOCTYPE >
<html>
    <head>
        <title>HTML Forms</title>
    </head>
    <body>
        <ul>
            <?php
                if (isset($_GET['person'])){
                    $person =
                       htmlspecialchars($_GET['person']);
                    echo "Hello, $person";
                } else {
                  ?>
                    <form>
                        Name: <input type="text" name="person" />
                        <br>
                        <input type="submit">
                    </form>
                <?php } ?>
        </ul>
    </body>
</html>