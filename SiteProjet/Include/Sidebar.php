<article id="SideBar">

  <link href="font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet">

<div id="nav-side-menu" class="nav-side-menu">
    <div class="brand"><?php
                          if (isset($_SESSION['pseudo']))
                            {
                              echo 'Bonjour ' . $_SESSION['pseudo'];
                            }
                          else
                          {
                            echo 'Bonjour à toi ! ';
                          }
                          
                          ?>
    </div>
      
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