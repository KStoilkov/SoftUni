<?php
    $n = 1234;
    $founded = false;
    for ($i = 100; $i <= $n; $i++) {
        if ($i >= 1000) {
            break;
        }
        echo $i . "\n";
        $founded = true;
    }
    if (!$founded) {
        echo "no";
    }
?>