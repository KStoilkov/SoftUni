<!DOCTYPE html>
<html>
<head lang="en">
    <meta charset="UTF-8">
    <title>Form Data</title>
    <style>
        form {
            border: 1px solid black;
            border-radius: 5px;
            box-shadow: 0 0 10px #000;
            width: 200px;
            padding: 10px;
        }
        input[type=text], input[type=submit] {
            display: block;
            margin: 5px;
            padding: 2px;
        }
    </style>
</head>
<body>
<form action="" method="get">
    <input type="text" placeholder="Name.." name="userName"/>
    <input type="text" placeholder="Age.." name="userAge"/>
    <input type="radio" id="male" name="gender" value="male"/>
    <label for="male">Male</label>
    <input type="radio" id="female" name="gender" value="female"/>
    <label for="female">Female</label>
    <input type="submit" value="Submit">
</form>
<?php
if (isset($_GET["userName"])) {

    ?>
    <p>My name is <?php echo htmlentities($_GET["userName"]) ?>.
        I am <?php echo htmlentities($_GET['userAge']) ?> years old.
        I am <?php echo htmlentities($_GET['gender']) ?>.
    </p>
<?php
}
?>
</body>
</html>