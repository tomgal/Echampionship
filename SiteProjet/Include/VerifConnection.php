<?php
session_start();
include('mysql.inc.php');
$bdd->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

if (isset($_SESSION['pseudo']))
{
    header('location: ../InscriptionTournois.php');
}
else
{

    $md5_pass = md5($_POST['password']);
    $pseudo = $_POST['username'];

    $reponse = $bdd->query('SELECT pseudo, password from user where pseudo = "'.$pseudo.'"');

    $resultat = $reponse->fetch();

    if($resultat['password'] == $md5_pass ){
        $_SESSION['pseudo'] = $pseudo;
        header('location: ../InscriptionTournois.php');

    }
    else
    {
        header('location: ../Accueil.php');
        alert('Mauvais identifiant ou mot de passe !');
    }
}
?>
