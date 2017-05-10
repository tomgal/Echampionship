<!DOCTYPE html>
<html lang="fr">
<head>
  <title>Echampionship</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
  <link rel="stylesheet" href="css/Page Accueil.css">

</head>
<?php
            session_start();
            if (isset($_SESSION['pseudo']))
            {
                header('location: InscriptionTournois.php');
            }
            else{
echo
'<header>
  <div class="row">
      <img src="Image/echampionship.png" />
    </div>

</header>  

<body style="padding:0px; margin:0px;font-family:"Open Sans",sans-serif,arial,helvetica,verdana">

 <section  class="col-sm-offset-0 col-sm-0">
    <article id="Carousel" class="col-sm-4"> 


<!-- #region Jssor Slider Begin -->
<!-- Generator: Jssor Slider Maker -->
<!-- Source: http://www.jssor.com -->
<!-- This is deep minimized code which works independently. -->
<script src="Js/Accueil.js"></script>

<div id="jssor_1" style="position:relative;margin:0 auto;top:0px;left:0px;width:800px;height:356px;overflow:hidden;visibility:hidden;background-color:#24262e;">
<!-- Loading Screen -->
<div data-u="loading" style="position: absolute; top: 0px; left: 0px;">
<div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
<div style="position:absolute;display:block;top:0px;left:0px;width:100%;height:100%;"></div>
</div>
<div data-u="slides" style="cursor:default;position:relative;top:0px;left:0px;width:800px;height:356px;overflow:hidden;">
<div>
<img data-u="image" src="Image/CSGO.jpg" />
</div>
<div>
<img data-u="image" src="Image/Dota2.jpg" />
</div>
<div>
<img data-u="image" src="Image/Fifa17.jpg" />
</div>
<div>
<img data-u="image" src="Image/Hearthstone.jpg" />
</div>
<div>
<img data-u="image" src="Image/LOL.jpg" />
</div>
<div>
<img data-u="image" src="Image/Overwatch.jpg" />
</div>
<div>
<img data-u="image" src="Image/Starcraft2.jpg" />
</div>
<div>
<img data-u="image" src="Image/WOW.jpg" />
</div>

<!-- Thumbnail Navigator -->
<div data-u="thumbnavigator" class="jssort01" style="position:absolute;left:0px;bottom:0px;width:800px;height:100px;" data-autocenter="1">
<!-- Thumbnail Item Skin Begin -->
<div data-u="slides" style="cursor: default;">
<div data-u="prototype" class="p">
<div class="w">
<div data-u="thumbnailtemplate" class="t"></div>
</div>
<div class="c"></div>
</div>
</div>
<!-- Thumbnail Item Skin End -->
</div>
<!-- Arrow Navigator -->
<span data-u="arrowleft" class="jssora05l" style="top:158px;left:8px;width:40px;height:40px;background:url(Image/fleche_gauche.jpg)"></span>
<span data-u="arrowright" class="jssora05r" style="top:158px;right:8px;width:40px;height:40px;background:url(Image/Fleche_droite.jpg)";></span>
</div>
<script type="text/javascript">jssor_1_slider_init();</script>
<!-- #endregion Jssor Slider End -->
</body>

    </article>
</section>

<!-- Code Connexion -->
<article class="col-sm-4">
<div class="col-xs-12">
    
    <div class="main">
            
        <div class="col-xs-12 col-sm-6 col-sm-offset-4">
                    
            <h1>Connexion</h1>
            <form action="Include/VerifConnection.php" name="login" role="form" class="form-horizontal" method="post" accept-charset="utf-8">
                <div class="form-group">
                <div class="col-md-12"><input name="username" placeholder="Idenfiant" class="form-control" type="text" id="UserUsername"/></div>
                </div> 
                <br/>
                <br/>
                <div class="form-group">
                <div class="col-md-12"><input name="password" placeholder="Mot de passe" class="form-control" type="password" id="UserPassword"/></div>
                </div> 
             
                <div class="form-group">
                <div class="col-md-offset-0 col-md-10"><input  class="btn btn-success btn btn-success" type="submit" value="Connexion"/></div>
                </div>
          </form>
        </div>
        </div>
        
    </div>
</div>
</div>
</article>

            
<!-- Code Inscription -->
<script type="text/javascript" src="Js/testFormu.js"></script>
<article class="col-sm-4">
<form method="post" action="Include/VerifInscription.php">
 <div class="row">
<div class="col-md-offset-0 col-md-6">
<h1> Inscription <br/></h1>
</div>
</div>


<div class="row">
<div class="col-md-offset-0 col-md-6">
<div class="form-group">
<input type="text" class="form-control"  name="pseudo" id="pseudo" placeholder="Pseudo" onblur="verifPseudo(this)">
</div>
</div>
</div>
<br/>
<br/>

<div class="row">
<div class="col-md-offset-0 col-md-6">
<div class="form-group">
<input type="text" class="form-control" name="email" id="email" placeholder="Enter email" onblur="verifMail(this)">
</div>
</div>
</div>
<br/>
<br/>

<div class="row">
<div class="col-md-offset-0 col-md-6">
<div class="form-group">
<input type="password" class="form-control" name="mdp1" id="password" placeholder="Mot de passe" onblur="verifMdp1(this)">
</div>
</div>
</div>
<br/>
<br/>

<div class ="row">
<div class="col-md-offset-0 col-md-6">
<div class="form-group">
<input type="password" class="form-control" name="mdp2" id="vpassword" placeholder="Vérification mot de passe" onblur="verifMdp1(this)">
</div>
</div>
</div>
</div>
<br/>
<br/>

<br/>
  <div class="row">
  <div class="col-md-offset-0 col-md-1">
  <input id="BtnInscript" type="submit" class="btn btn-primary" value ="Envoyer mes informations">
  </div>
  </div>
 </article> 
 </form>
</div>
</section>
</body>


<footer>
</footer>
</html>';
}
