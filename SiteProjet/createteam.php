<?php

session_start(); // On démarre la session AVANT toute chose
?>

<!DOCTYPE html >
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="fr" >
<meta charset="UTF-8">
<head>
<link rel="stylesheet" href="Css/bootstrap.css">
<link rel="stylesheet" href="Css/createteam.css">
<link href="bootstrap/fonts/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet">
	
    <title> Créer une Team </title>

  </head>
	
	

  <body>

 
	 <header>

	     <h1> Créer une team </h1>

	 </header>

    

    <!-- SideBar -->
    <article id="SideBar">

   		

      <div class="nav-side-menu">
      <div class="brand">EChampionship</div>

        <i class="fa fa-bars fa-2x toggle-btn" data-toggle="collapse" data-target="#menu-content"></i>
  
        <div class="menu-list">


            

  
          <ul id="menu-content" class="sub-menu collapse">

                  <li>
                    <a href="#">
                    <i class="fa fa-home fa-lg"></i> Accueil
                    </a>
                  </li>

                 <li  data-toggle="collapse" data-target="#products" class="collapsed">

                    <a href="#">
                    <i class="fa fa-user fa-lg"></i> Mon compte </a>                                 
                


                  <li data-toggle="collapse" data-target="#" class="collapsed">
                    <a href="#">
                   <i class="fa fa-users fa-lg"></i> Team 
                    </a>
                  </li>  


                  <li data-toggle="collapse" data-target="#" class="collapsed">
                    <a href="#"><i class="fa fa-diamond fa-lg"></i> Paris </a>
                  </li>
               


                   <li>
                    <a href="#">
                   <i class="fa fa-globe fa-lg"></i> Tournois
                    </a>
                   </li>

                   <li>
                    <a href="#">
                    <i class="fa fa-trophy fa-lg"></i> Championnats
                    </a>
                 </li>

                  <li>
                    <a href="#">
                    <i class="fa fa-cog fa-lg"></i> paramètres
                    </a>
                  </li>

                  <li>
                    <a href="#">
                    <i class="fa fa-power-off fa-lg"></i> Déconnexion
                    </a>
                  </li>
              </ul>
         </div>
     </div>  
  	</article> 





	
	<!--Fin SideBar-->  

	<!--Formulaire-->


	<article id="Formulaire">

	   	<form id="tbprenom" action="" method="POST"> 

	   		<input type="text" name="prenom" placeholder="Nom de la team" /> 
					
		  	<p>
			   	<input type="text" name="membres" placeholder="Pseudo">
				  <!-- <input type="submit" value="ajouter" onclick="self.location.href='CreateTeam.php'" /> -->
					 <input type="submit" value="Rechercher" />
			 </p>
      </form>

      <form id="Validate" action="" method="POST">

        <p>
				  <input type="submit" value="Créer la Team" />
			 </p> 
      </form>

		  <!--Fin Formulaire-->
		  <?php
		include("PhpCreateTeam.php");
		?>
    </article>

	<article id="Tableau">



	<!-- <?php 

		/* $equipier = array ($_SESSION['NameTeam']);

		for ($numero = 0; $numero < 2; $numero++)
		{
    		echo $equipier[$numero] . '<br />'; // affichera $prenoms[0], $prenoms[1] etc.
		} */ 

	?> -->


	</article>

  </body>
</html>