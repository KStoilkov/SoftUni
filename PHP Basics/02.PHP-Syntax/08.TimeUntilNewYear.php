<?php
$newYear = new DateTime('01/01/2015');
$currentDateTime = new DateTime();

$diff = $newYear->diff($currentDateTime);
$hours = $diff->days * 24 + $diff->h;
$minutes = $hours * 60 + $diff->i;
$seconds = $minutes * 60 + $diff->s;
$days = $diff->days;

echo "Hours until new year : " . $hours . "\n";
echo "Minutes until new year : " . $minutes . "\n";
echo "Seconds until new year : " . $seconds . "\n";
echo "Days:Hours:Minutes:Seconds " . $days . ":" . $diff->h . ":" . $diff->i . ":" . $diff->s ."\n";
?>
