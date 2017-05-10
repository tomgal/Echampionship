<?php
session_start();
$valide = true;

include('mysql.inc.php');
$bdd->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);


    
if(strlen($_POST['pseudo']) != 0)  $pseudo = $_POST['pseudo'];
    else
    {
        $pseudo = ""; 
        $valide = false;
        echo'Veuillez rentrer un pseudo Valide.';
    }

	if(strlen($_POST['email']) != 0)  $email = $_POST['email'];
    else
    {
        $email = ""; 
        $valide = false;
        echo'Veuillez rentrer un mail Valide.';
    }
	
if(strlen($_POST['mdp1']) != 0)   $mdp1 = $_POST['mdp1'];
    else
    {
        $mdp1 = ""; 
        $valide = false;
        echo'Veuillez rentrer un mot de passe non vide.';
    }
	
if(strlen($_POST['mdp2']) != 0)   $mdp2 = $_POST['mdp2'];
    else
    {
        $mdp2 = ""; 
        $valide = false;
        echo'Veuillez rentrer un mot de passe non vide.';
    }
	
$reponse = $bdd->query('SELECT pseudo, Mail from user where pseudo = "'.$pseudo.'" or Mail = "'.$email.'"');
$donnees = $reponse->fetch();

$reponse2 = $bdd->query('SELECT pseudo FROM user WHERE pseudo=\'pseudo\'');
     
    while ($donnees2 = $reponse2->fetch())
    {
        echo 'Il y a déjà une personne qui utilise '.$donnees2['pseudo'] .' comme pseudo !<br />';
    }
    
    $reponse2->closeCursor();

if($valide == true)
{
    if($donnees['pseudo'] == null)
    {
        if($donnees['mail'] == null)
        {
            if($mdp1 == $mdp2)
            {
                $mdp1 = md5($mdp1);
                $bdd->query('INSERT INTO user(pseudo, password, Mail) VALUES("'.$pseudo.'","'.$mdp1.'","'.$email.'")');
                echo('Enregistrement Effectué.');
                header('location: ../Accueil.php');
            }
            else
            {
                header('location: ../Accueil.php');
                echo('Veuillez rentrer deux mots de passes identiques.');
            }
        }
        else
        {
            header('location: ../Accueil.php');
            echo('Cet Email est deja pris.');
        }
    }
    else
    {
        header('location: ../Accueil.php');
        echo('Ce Pseudo est déja pris par un Membre.');
    }
}
    
?>