<?php
$_SESSION = array(); // vide le tableau des sessions
 
session_destroy(); // détruit la session
 
header("location:Accueil.php");

?>