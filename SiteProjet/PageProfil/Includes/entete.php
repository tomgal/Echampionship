<?php
// Définit le fuseau horaire par défaut à utiliser. Disponible depuis PHP 5.1
date_default_timezone_set('Europe/Paris');



$heure = date('H');
$minute = date('i');

echo '<strong>' . $heure . 'h' . $minute . '</strong>';

?>

