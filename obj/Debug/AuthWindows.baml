   M S B A M L   `   `   `  ����C  ?HotelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HotelAppHotelApp  5   	       HotelApp.AuthWindows   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:HotelApp     5   	     � Title$'  !Байкальский отдых��5   	   $	��400��5	   	   $	��500��5
   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � 	Resources 5       �� 
TargetType �� 	Resources �� Color��%�   '��       �� 5   
   " ��6    5      ���� 5      $ White��6R   (��       6"   *SystemColors.ControlBrushKey+)6R   5      5      5      .��5      �� ���#1D2028���#3A4149$��5q�5      	 �� CornerRadius$	 
8, 8, 0, 8��5      ._�5   
   � 
 � RowDefinitions
 5      �� 5      $��* �6    �� 5      $��* �6    �� 5       $��* �6    �� 5!      $��* �6    .+�5#      �� $��0��6   $��Center=�6%   $��Center=�6B   $
��Wrap=�6]   $��Авторизация��6q   ���#E1DED6$��32(�6�    �� 
LineHeight$ 12��6�   �� 5$      $��3��6   $��Center=�6&   $	��300��6C   $��50��6O   .+�5%      �� -   5         ��Name$ AuthBtn��5%      
������ $	��300��6Y   $��50��6e   $��0q�6q   $��32(�6�   $��Center=�6�   ���#E1DED6.��5&      �� $	 12��6   $	��300��6/   $��80��6;   ���#E1DED6$��Center=�6]   $��Center=�6x   ._�5'      �� $��28(�6$   $��
Войти��62   ���#1D2028$
��Bold"�6T   $��Center=�6f   $��Center=�6�   5(      5)      5*      �� 5+      $��1��6   $��Center=�6&   $��Center=�6C   .+�5,      �� $��
Логин��6   $��16(�6)   ���#E1DED667   �� 5-      ���#E1DED6$��2q�6/   $	 10��6C   $	��300��6V   $��40��6b   ._�5.      �� -   5         ��Name$ login��5.       �� TextWrapping$
 Wrap=�66   $	��300��6K   $��40��6W   $��0q�6c   ���#E1DED6
������ $��8q�5/   $   51      52      �� 53      $��2��6   $��Center=�6&   $��Center=�6C   .+�54      �� $��Пароль��6   $��16(�6*   ���#E1DED668   �� 56      ���#E1DED6$��2q�6/   $	 10��6C   $��2��6U   $	��300��6b   $��40��6n   ._�57      �� -   5        $ password��57      $��Center=�60   $��Center=�6M   $
 Wrap=�58   
   $	��300��6   $��40��6*   $��0q�66   ���#E1DED6
������ $��8q�59   $   5:      5;      5<      5=      5>      