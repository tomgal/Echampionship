   M S B A M L   `   `   `  ����L  HEChampionshipMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EChampionshipMVVM.ViewEChampionshipMVVM.View  5   	   %    EChampionshipMVVM.View.TeamView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EChampionshipMVVM.View     5   	     � Title$  Mes Teams - eChampionship��5   	   $	��720��6+   $
��1280��68   $	��720��6E   $
��1280��6U    � DataContext 5	   	   ��    Locator �� Source# [   �� Path$
 Team�.��5
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
   -   5        $ backgroundProfile��50      $��3��6+   $��0��6f   $��3��6s    J� Opacity$
 0.45Q�6�   $��4��6�   ��6;   �� *EquipeEnCours.UrlProfil+6�   �� 51   
   -   5        $ image��51      $��6��6   $��0��6/   $��3��6k   $��20,20,20,20q�6|   ��6<   �� *EquipeEnCours.UrlBackground+6|   �� 52   
   -   5        $
 name��52      $��4��6"   $��2��62   $��Center=�6F   $
��Wrap=�6c   $��Center=�6�   $��50(�6�   $
��Bold"�6�   $��Segoe UI Black)�6�   ��6w   �� *EquipeEnCours.Nom+6�   53      54      