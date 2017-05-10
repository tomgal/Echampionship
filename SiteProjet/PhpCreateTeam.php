<?php



// Dans cette première requete, on va créer l'équipe dans la BDD
try{
	
	// On se connecte à MySQL
	$bdd = new PDO('mysql:host=localhost;dbname=echampionship;charset=utf8', 'root', '');
}

catch(Exception $e){
	
	// En cas d'erreur, on affiche un message et on arrête tout
    die('Erreur : '.$e->getMessage());
}

if(array_key_exists("prenom", $_POST)):
// Si tout va bien, on peut continuer
	$textEntree = $_POST['prenom'];

		

	// On lance la requête pour créer l'équipe dans la BDD
	$envoie = $bdd->query('INSERT INTO equipe (niveauEq, NomEquipe) VALUES ("medium", "'.$textEntree.'")');

	//On envoie une requête en réponse pour vérifier si l'équipe a bien été créer
	$repNomEquipe = $bdd->query('SELECT NomEquipe FROM equipe WHERE NomEquipe = "'.$textEntree.'" ');


	$_SESSION['NameTeam'] = $textEntree;

	

	//On affiche le nom de l'équipe
	while ($donnees = $repNomEquipe->fetch()):

		?>

		<p>
    		<strong><?php echo $_SESSION['NameTeam']; ?> </strong>
  		</p>


		<?php

	endwhile;

endif; 


//Dans la seconde requete, on recherche les joueurs existants pour les ajouter à l'équipe

try{
	
	// On se connecte à MySQL
	$bdd = new PDO('mysql:host=localhost;dbname=echampionship;charset=utf8', 'root', '');
}


catch(Exception $e){
	
	// En cas d'erreur, on affiche un message et on arrête tout
    die('Erreur : '.$e->getMessage());
}

if(array_key_exists("membres", $_POST)):
	// Si tout va bien, on peut continuer

	$textEntree = $_POST['membres'];


	// On récupère tout les pseudo des joueurs qui corresponde au nom entrée
	$reponse = $bdd->query('SELECT Pseudo FROM user WHERE Pseudo like "%'.$textEntree.'%"');


	// On affiche chaque entrée une à une 
	// On creer un form pour ajouter les joueurs à l'équipe 
	while ($donnees = $reponse->fetch()):

		?>

		<p>
			<form id="addName" name="addMembres" action="" method="POST">

    			<strong>Pseudo</strong> : <?php echo $donnees['Pseudo']
    			?>

    			<input type="submit" value="ajouter" />

    		</form>
  		</p>


		<?php

	endwhile;

	$reponse->closeCursor(); // Termine le traitement de la requête

	//header('location: CreateTeam.php');
endif;




// On relie les joueurs à l'équipe

try{
	
	// On se connecte à MySQL
	$bdd = new PDO('mysql:host=localhost;dbname=echampionship;charset=utf8', 'root', '');
}


catch(Exception $e){
	
	// En cas d'erreur, on affiche un message et on arrête tout
    die('Erreur : '.$e->getMessage());
}

if(array_key_exists("addMembres", $_POST)):
	// Si tout va bien, on peut continuer

	$Pseudo = $_POST['Pseudo'];


	// On récupère l'id du joueur
	$repIdUser = $bdd->query('SELECT IdUser FROM user WHERE Pseudo="'.$Pseudo.'"');

	//Puis celui de l'equipe
	$repIdTeam = $bdd->query('SELECT IdEquipe FROM equipe WHERE NomEquipe="'.$repNomEquipe.'" ');

	//On relie l'équipe au joueur.
	$requete = $bdd->query('INSERT INTO  contenir (IdUser,IdEquipe) VALUES ("'.$repIdUser.'", "'.$repIdTeam.'") ');






	// On affiche chaque entrée une à une
	while ($donnees = $repId->fetch()):

		?>

		<p>

    			<strong>Pseudo</strong> : <?php echo $donnees['repIdUser'];
    											echo $donnees['repIdTeam'] ?>
  		</p>


		<?php

	endwhile;

	$reponse->closeCursor(); // Termine le traitement de la requête

	//header('location: CreateTeam.php');
endif;




?>