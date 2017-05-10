<!DOCTYPE html PUBLIC>

<head>
<link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
<link rel="stylesheet" href="Css/InscripTournois.css">
<meta charset="utf-8">
    <title> Echampionship</title>
</head>
 

<body>
<article>
<!-- slider -->
<script src="Js/InscripTournois.js"></script>

<div id="jssor_1" style="position:relative;margin:0 auto;top:0px;left:0px;width:800px;height:356px;overflow:hidden;visibility:hidden;background-color:#24262e;">
<!-- Loading Screen -->
<div data-u="loading" style="position: absolute; top: 0px; left: 0px;">
<div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
<div style="position:absolute;display:block;top:0px;left:0px;width:100%;height:100%;"></div>
</div>
<div data-u="slides" style="cursor:default;position:relative;top:0px;left:0px;width:800px;height:356px;overflow:hidden;">
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
<script type="text/javascript">jssor_1_slider_init();</script>
</article>

<!-- menu à gauche -->
<?php
include 'PageProfil/Includes/Sidebar.php';
?>


<!-- tableau liste tournois -->
<table>
   <caption>Tournois</caption>

  <thead> <!-- En-tête du tableau -->
    <tr>
        <th>Nom</th>
        <th>Date</th>
        <th>Lieu</th>
        <th>Organisateur</th>
    </tr>
  </thead>
  <tbody> <!-- Corps du tableau -->
    <tr>
        <td>MSI Champion Cup</td>
        <td>28 avril</td>
        <td>Bresil</td>
        <td>MSI</td>
    </tr>
  </tbody>
</table>
</section>
</body>