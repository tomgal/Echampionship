<?php
include('mysql.inc.php');
$bdd->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

if (POST('image') == 'WOW.jpg')
{
    $tournois = array();
    //récup image

    $reponse = $bdd->query('SELECT * from Tournois where jeux = "'.$image.'"');

    $resultat = $reponse->fetch();

    //insertion dans tableau

    while($resultat)
    {
        $tournois[] = $resultat;
        next($tournois);
    }
}
?>