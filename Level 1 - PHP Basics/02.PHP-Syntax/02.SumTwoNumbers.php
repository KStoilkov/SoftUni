<?php
    $firstNumber = array(2 , 1.567808, 1234.5678);
    $secondNumber = array(5, 0.356, 333);
    for ($i = 0; $i < count($firstNumber); $i++) {
        $sum = $firstNumber[$i] + $secondNumber[$i];
        $sum = number_format($sum,2);
        echo $sum . "\n";
    }
?>