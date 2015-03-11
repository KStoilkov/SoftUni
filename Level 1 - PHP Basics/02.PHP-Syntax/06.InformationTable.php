<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html;charset=UTF-8">
    <title>Information Table</title>
    <style>
        table {
            border-collapse: collapse;
        }
        td {
            border: 1px solid black;
            padding: 5px;
        }
        table tr td:first-child {
            background-color: #FF9C00;
        }
        table tr td:last-child {
            text-align: right;
        }
    </style>
</head>
<body>
    <?php
        $input = array("Gosho", "0882-321-423", "24", "Hadji Dimitar");
        //$input = array("Pesho", "0884-888-888", "67", "Suhata Reka");
        $tableInfo = array("Name", "Phone number", "Age", "Address");
    ?>
    <table>
    <?php
        for ($i = 0; $i < count($input); $i++) {
    ?>
            <tr><td><?=$tableInfo[$i]?></td><td><?=$input[$i]?></td></tr>
    <?php
        }
    ?>
    </table>
</body>
</html>
