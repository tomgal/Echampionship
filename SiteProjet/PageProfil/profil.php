<!DOCTYPE html>
<html lang="fr">
	<head>
	 	<meta charset="utf-8">
		<title>Profil</title>
		<link rel="stylesheet" href="CSS/InscriptTournois.css">
	</head>
	<body>
		<div id="conteneur">
			<?php
				session_start();
				include('Includes/mysql.inc.php');
               	include 'Includes/Sidebar.php';
            ?>		
            <header id="entete">

				<!--<img id="imgBanner" src="http://placehold.it/1340x255">-->
				<h1>Cheepyy</h1>
				<div class="div-diamand">
					100 &nbsp;<i class="fa fa-diamond fa-2x"></i><br><a href="#" class="diamandPlus">Obtenir Plus</a>
				</div>
				<div class="photoProfil" align="right">
					<img src="http://placehold.it/155x155">
				</div>				
			</header>
			<div class="infoPro">
			<a class="modifierProfil" href="#">Modifier</a>
				<fieldset class="affichageProfil">
					<label>Pseudo :</label><br>
					<label>Email :</label><br>
					<label>Prénom :</label><br>
					<label>Nom :</label><br>
					<label>Date de naissance :</label><br>
				</fieldset>
			</div>
			<div class="jeuxInfo">
				<h2> Mes Jeux :</h2>
				<section class="secJeux">
					<a href=""><img src="http://placehold.it/155x140"></a>

					<a href=""><img src="http://placehold.it/155x140"></a>

					<a href=""><img src="http://placehold.it/155x140"></a>

					<a href=""><img src="http://placehold.it/155x140"></a>
				</section>
				<section class="secJeux">
					<a href=""><img src="http://placehold.it/155x140"></a>

					<a href=""><img src="http://placehold.it/155x140"></a>

					<a href=""><img src="http://placehold.it/155x140"></a>

					<a href=""><img src="http://placehold.it/155x140"></a>
				</section>
			</div>
		</div>

	</body>
</html>