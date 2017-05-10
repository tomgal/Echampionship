<?php 
try
    {
        //Connection a la base de données.
        $bdd = new PDO('mysql:host=localhost;dbname=echampionship;charset=utf8','root','');
    } 
    catch(Exception $e)
    {
        die('Erreur : '.$e->getMessage());
    }
?>