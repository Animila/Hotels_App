   M S B A M L   `   `   `  ����C  ?HotelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HotelAppHotelApp  5   	       HotelApp.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   b ^SharpVectors.Converters.Wpf, Version=1.8.2.0, Culture=neutral, PublicKeyToken=b532964b8548be770svg&http://sharpvectors.codeplex.com/svgc/  5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   <d2http://schemas.microsoft.com/expression/blend/2008   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   $localclr-namespace:HotelApp   5   	   -   5          �Name$  ResponsiveWindow��5
   	    � Title$' !Байкальский отдых��5   	   $	��750��5   	   $
��1300��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � 	Resources 5         MenuSlideIn �� 
TargetName �� TargetProperty		 W� To
 g� Duration  MenuSlideOut��%A  &	        &	 �     �� 5   
   .��5      W� $ Sidebar��6   $, &RenderTransform.(TranslateTransform.X)�5      $
	 -237X�5      $
 0:0:0.3D�6$   5      �� 5   
   .��5      W� $ Sidebar��6   $, &RenderTransform.(TranslateTransform.X)�5      $	 0X�5      $
 0:0:0.3D�6!   5      5       .��5"      �� -   5        ���#1D2028���#3A4149$��5q�5$       �� CornerRadius$ 
8, 8, 0, 8��5%      ._�5(   
   �  � ColumnDefinitions 5)      �� 5*      $	��237 �6#   �� 5+      $��* �6#    � RowDefinitions 5.      �� 5/      $��75 �6    �� 50      $��* �6    .+�54      �� -   5        $��0��54   *   $��27, 0, 0, 0q�67     	topButton#��[ 6L   .��55      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6(   $��30��64   $��30��6?   56      �� 57      -   5        $��1��57      #��[ 6%   $��X��6I   $��Right=�6U   $	��Top=�6q   $��	0,10,10,0q�6�   $��30(�6�   $��42��6�   �� 59      -   5         ��Name$ Sidebar��59   !   $	��237��6   $��1��62   ���#2A2F3A$ 0, 60, 0, 0��6T   z�5:      T� 5;       T� X$ 0Q�6)   ._�5=      �� .+�5>      �� $
��Left=�6!   $��19, 24, 0, 0q�6<   .+�5?      �� -   5         ��Name$ firstLastName��5?   $   $%��Илья Христофоров��6;   $	��180��6S   $
��Wrap=�6_   ���#E1DED6$��24(�6�    �� 
LineHeight$ 12��6�   �� 5@      -   5        $ typeUser��5@   $   $ ��Администратор��66   $	��180��6K   $
��Wrap=�6W   ���#E1DED6$��18(�6�   $��Regular"�6�   5A      �� 5B      $
��Left=�6!   $��0, 102, 0, 0q�6<   .+�5C      �� -   5          
menuButton#��[ 5C   !   .��5D      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5E   "   �� $��/Assets/home.png��6(   $��20��6B   $��0, 0, 14, 0q�6M   �� 5F   "   $��Статистика��6,   $	��180��6>   $
��Wrap=�6J   ���#E1DED6$ 20��6s   $��Center=�6�   $��Center=�6�   5G      5H      5I      �� 5J      $
��Left=�6!   $��0, 42, 0, 0q�6<   .+�5K      �� -	   5        #��[ 5K   O   ��6!   �� *AdministrationViewCommand+.��5L      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5M   "   �� $��/Assets/setting.png��6(   $��20��6E   $��0, 0, 14, 0q�6P   �� 5N   "   $��Управление��6,   $	��180��6>   $
��Wrap=�6J   ���#E1DED6$ 20��6s   $��Center=�6�   $��Center=�6�   5O      5P      5Q      �� 5R      $
��Left=�6!   $��0, 42, 0, 0q�6<   .+�5S      �� -
   5        #��[ 5S   !   .��5T      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5U   "   �� $��/Assets/person.png��6(   $��20��6D   $��0, 0, 14, 0q�6O   �� 5V   "   $��Профиль��6,   $	��180��6;   $
��Wrap=�6G   ���#E1DED6$ 20��6p   $��Center=�6�   $��Center=�6�   5W      5X      5Y      �� 5Z      $
��Left=�6!   $��0, 42, 0, 0q�6<   $��Bottom=�6Q    K� ZIndex$ 10��6l   .+�5[      �� #��[ 6!   .��5\      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5^   "   �� $�� ��6,   $	��180��64   $
��Wrap=�6@   ���#E1DED6$ 20��6i   $��Center=�6y   $��Center=�6�   5_      5`      5a      �� 5b      $
��Left=�6!   $��0, 42, 0, 0q�6<   $��Bottom=�6Q   $ 10��6l   .+�5c      �� #��[ 6!   .��5d      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5f   "   �� $�� ��6,   $	��180��64   $
��Wrap=�6@   ���#E1DED6$ 20��6i   $��Center=�6y   $��Center=�6�   5g      5h      5i      �� 5j      $
��Left=�6!   $��0, 42, 0, 0q�6<   $��Bottom=�6Q   $ 10��6l   .+�5k      �� #��[ 6!   .��5l      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5n   "   �� $�� ��6,   $	��180��64   $
��Wrap=�6@   ���#E1DED6$ 20��6i   $��Center=�6y   $��Center=�6�   5o      5p      5q      �� 5r      $
��Left=�6!   $��0, 42, 0, 0q�6<   $��Bottom=�6Q   $ 10��6l   .+�5s      �� -   5        #��[ 5s   "   .��5t      �� $ 
Horizontal=�6)   $��Center=�6B   $��Bottom=�6_   .+�5u   "   �� $��/Assets/logout.png��6(   $��20��6D   $��0, 0, 14, 0q�6O   �� 5v   "   $��
Выход��6,   $	��180��69   $
��Wrap=�6E   ���#E1DED6$ 20��6n   $��Center=�6~   $��Center=�6�   5w      5x      5y      5z      5{       � 5}      -   5        $��MainContentFrame��5}   F   $��1��6   $��40, 5, 0, 0q�6!   $��1��66     � NavigationUIVisibility$ Hidden=�6^   5~      5�      5�      