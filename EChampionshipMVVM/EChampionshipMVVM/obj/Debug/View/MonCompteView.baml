   M S B A M L   `   `   `  ����L  HEChampionshipMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EChampionshipMVVM.ViewEChampionshipMVVM.View  5   	   *    $EChampionshipMVVM.View.MonCompteView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EChampionshipMVVM.View     5   	     � Title$   Mon Compte - eChampionship��5   	   $	��720��6,   $
��1280��69   $	��720��6F   $
��1280��6V    � DataContext 5	   	   ��    Locator �� Source# [   �� Path$ Compte�.��5
      �  � RowDefinitions 5   
   �� 5      $
��126* �6   �� 5      $	��42* �6   �� 5      $	��59* �6   �� 5      $	��65* �6   �� 5      $	��65* �6   �� 5      $	��65* �6   �� 5      $	��65* �6   �� 5      $	��65* �6   �� 5      $	��65* �6   �� 5      $	��65* �6    � ColumnDefinitions 5   
   �� 5      $
��167* �6   �� 5      $	��52* �6   �� 5      $	��53* �6   �� 5      $
��236* �6   �� 5      $
��290* �6   �� 5      $
��290* �6   �� 5      $
��184* �6   .+�5    
   �� -   5         ��Name$ photoProfil��5       $��0��6F   $��0��6V   ��6%   �� *User.UrlImage+6V   �� 5!   
   -   5         ��Name$ pseudoUtilisateur��5!      $��3��6/   $��0��6C   $��1��6S   $
��Wrap=�6`   $��20(�6�   $��Segoe WP)�6�    �� TextAlignment$ Center=�6�   ���	#FF00A2FF��6t   �� *User.Pseudo+6�   �� 5"   
   $��3��6   ���	#FF0080FF$��2��6<   $��2��6M   �� 5#   
   -   5        $ image_credit��5#      $��2��6&   $��0��66   $��Center=�6C   $ ��/Images/diamand_credit.png��6^   $
��Left=�6�   $��30��6�   $
��0,48q�6�   $��30��6�   �� 5$   
   -   5        $ nbCredit��5$      $��1��6&   $��0��66   $
��Wrap=�6C   $��Center=�6t   $��20(�6�   $
��Bold"�6�   ���	#FF0080FF$��Right=�6�   ��6W   �� *User.Credit+6�   �� 5%   
   $��3��6   ���	#FF0080FF$��1��6<   $��2��6J   �� 5&   
   $��0��6   ���	#FF0080FF$��0��68   $��2��6F   �� 5'   
   -   5        	 ��Name$	 menuList��5'      $��3��6S   $��2��6g   $��2q�6t   ���	#FF0080FF$��8��6�   ��6%   �� *
MenuItem+
 �� Mode$
 OneWay=���5(      �� 5)      .R�5*      �� $��0��6!   $��1��61   $
��Wrap=�6>   $��25(�6c   $��Segoe WP)�6q   $��3��6�   $ Center=�6�   ���	#FF00A2FF$
��Bold"�6�   $��Stretch=�6�   $��
20,10,0,10q�6�    �� 
LineHeight$ 1��6  ��6R   �� 6  5+      5-      �� 50   
   -   5        $ backgroundProfile��50      $��3��6+   $��0��6e   $��3��6r    J� Opacity$
 0.45Q�6�   $��4��6�   ��6;   �� *User.BackgroundProfile+6�   �� 51   
   -   5        $ image��51      $��6��6   $��0��6/   $��3��6]   $��20,20,20,20q�6n   ��6<   �� *User.UrlImage+6n   �� 52   
   -   5        $
 name��52      $��4��6"   $��2��62   $��Center=�6F   $
��Wrap=�6c   $��Center=�6�   $��50(�6�   $
��Bold"�6�   $��Segoe UI Black)�6�   $��200,51,199,8q�6�   $��67��6  $	��181��6  ��6w   �� *User.Pseudo+6  �� 53   
   $��3��6   $��3��6%   $��2��62   $��7��6F   ���	#FF0080FF$��4��6j   $��30q�6~    �� RadiusY$ 10��6�    �� RadiusX$ 10��6�   �� 54   
   -	   5        $ 	pseudoDef��54      $��3��6'   $��Center=�67   $��4��6U   $
��Wrap=�6b   $��	Pseudo : ��6v   $��Center=�6�   $��40,0,0,0q�6�   $��25(�6�   $
��Bold"�6�   �� 55   
   -
   5        $ 	prenomDef��55      $��3��6'   $��Center=�67   $��5��6U   $
��Wrap=�6b   $��	Prenom : ��6v   $��Center=�6�   $��40,0,0,0q�6�   $��25(�6�   $
��Bold"�6�   �� 56   
   -   5        $ NomDef��56      $��3��6$   $��Center=�64   $��6��6R   $
��Wrap=�6_   $��Nom : ��6s   $��Center=�6�   $��40,0,0,0q�6�   $��25(�6�   $
��Bold"�6�   �� 57   
   -   5        $ EmailDef��57      $��3��6&   $��Center=�66   $��7��6T   $
��Wrap=�6a   $��Email : ��6u   $��Center=�6�   $��40,0,0,0q�6�   $��25(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.519,6.455&�6�   �� 58   
   -   5        $ Credit��58      $��3��6$   $��Center=�64   $��8��6R   $
��Wrap=�6_   $��	Credit : ��6s   $��Center=�6�   $��40,0,0,0q�6�   $��25(�6�   $
��Bold"�6�   �� 59   
   -   5        $ imageCredit��59      $��4��6%   $��8��65   $��Center=�6B   $<��6/EChampionshipMVVM;component/Images/diamand_credit.png��6]   $��Right=�6�   $��30��6�   $��30��6�   $��0,0,80,0q�6�   �� 5:   
   -   5        $ pseudo��5:      $��4��6$   $��Center=�64   $��4��6R   $
��Wrap=�6_   $��Center=�6�   $��0,0,40,0q�6�   $��20(�6�   ��6s   �� *User.Pseudo+6�   �� 5;   
   -   5        $ Prenom��5;      $��4��6$   $��Center=�64   $��5��6R   $
��Wrap=�6_   $��Center=�6�   $��0,0,40,0q�6�   $��20(�6�   ��6s   �� *User.Prenom+6�   �� 5<   
   -   5        $	 Nom��5<      $��4��6!   $��Center=�61   $��6��6O   $
��Wrap=�6\   $��Center=�6�   $��0,0,40,0q�6�   $��20(�6�   ��6p   �� *
User.Nom+6�   �� 5=   
   -   5        $ Email��5=      $��4��6#   $��Center=�63   $��7��6Q   $
��Wrap=�6^   $��Center=�6�   $��0,0,40,0q�6�   $��18(�6�   ��6r   �� *	User.Mail+6�   �� 5>   
   -   5        $ 
CreditInfo��5>      $��4��6(   $��Center=�68   $��8��6V   $
��Wrap=�6c   $��Center=�6�   $��0,0,40,0q�6�   $��20(�6�   ��6w   �� *User.Credit+6�   �� 5?   
   -   5        $ 	textBlock��5?      $��5��6'   $
��Left=�67   $��20,0,0,0q�6R   $��3��6d   $
��Wrap=�6q   $��
Mes jeux :��6�   $��Bottom=�6�   $��35(�6�   $
��Bold"�6�   $��	Underline{�6�   �� 5@   
   -   5        $	 listView��5@      $��5��6%   $��20,20,20,40q�65   $��4��6o   $��6��6|   $��2��6�   ��6J   �� *User.MyGames+��5A      �� 5B      .R�5C      �  5D      �� 5E      $��* �6/   �� 5F      $��* �6/   .+�5H      �� $ image1��6    $��0��60   $
��Left=�6@   $	��Top=�6w   $	��100��6�   $	��100��6�   ��6[   �� *
UrlImage+6�   �� 5I      $ nomJeu��6$   $��1��64   $��Center=�6Y   $��Center=�6v   ���	#FF4310F0$��15(�6�   $��Normal"�6�   $ Center=�6�   $��20,0,0,0q�6�   ��6D   �� *Nom+6�   5J      5K      5M      �� 5N   
   -   5        $ 
textBlock1��5N      $��4��6(   $��0,0,0,30q�68   $��9��6J   $
��Wrap=�6W   $��Informations IRL��6k   $��Center=�6�   $��15(�6�   $��Center=�6�   �� 5O   
   -   5        $ 
textBlock2��5O      $
��Left=�6(   $
��Wrap=�6C   $��	TextBlock��6W   $	��Top=�6h   5R      5S      