   M S B A M L   `   `   `  ����C  ?HotelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HotelAppHotelApp  5      7 clr-namespace:HotelApp.MVVM.ViewHotelApp.MVVM.View  5      b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          HotelApp.App   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      (localclr-namespace:HotelApp     5      1view clr-namespace:HotelApp.MVVM.View     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      YthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2   5        �� 	Resources  5	       �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels	 �Name
 J� Opacity � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName   DataGridStyle25  /System.Windows.Controls.DataGridLengthConverter �� Padding ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll  ��Name! �� ScrollableHeight" � Maximum# �� Orientation$ �� ViewportHeight% �� ViewportSize*& �� #ComputedVerticalScrollBarVisibility' � Value( �� Mode) �� ScrollableWidth* �� ViewportWidth,+ �� %ComputedHorizontalScrollBarVisibility, �� Triggers- ]� 
Conditions. �� Property/ �� Value  ColumnHeaderGripperStyle  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -Microsoft.Windows.Themes.DataGridHeaderBorder0   	IsPressed1 J� IsMouseOver2   	IsHovered3   CanUserSort4   IsClickable5   SortDirection6   SortDirection7   SeparatorVisibility8   SeparatorVisibility9   SeparatorBrush:   SeparatorBrush; n�Name  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow< ��Name= �� CornerRadius?	  9System.Windows.Controls.Primitives.SelectiveScrollingGrid?
  9System.Windows.Controls.Primitives.DataGridCellsPresenter>   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter?   DetailsVisibility$@ 	  SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientationA   Vertical#B   RowDetailsScrollingConverter:  4System.Windows.Controls.Primitives.DataGridRowHeader
C   Row  gridEditButton  gridDeleteButtonD �� BasedOn  gridBtnIcon.  (MahApps.Metro.IconPacks.PackIconMaterial  	topButton 	 
menuButton 
 adminBtn  ComboBoxStyle��%�#  (��       5      $" DataGridSelectAllButtonStyle��"  )&	  �    &	 @    &	 R    7  7  &	 �    &	 W    &	 2    &	 u    7  &	 �    &	     &		     &	
 C     &	 ="    '�� �"    7  �� 6
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ Border��6(   #��� ��68    . 6y   � 5      $	 Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $

 0.15Q�6o    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5       5      P� 5       �@J�IsMouseOver . . �5   "   �� $ Border��6;   # � ��6O    � ��5      P� 5       � �� . . �5   "   �� $ Border��69   # � ��6M    � ��5      P� 5       � {� .  . �5   "   �� $ Arrow��6?    � y�$ 	Collapsed=�6R   5      5      5       5!      �� 5"   
   "  6'   .�5#      ��  � ��
 ���� 6+   �� 5$       � �� �#D5D0C56+   �� 5%       � ��$ 0q�60   �� 5&        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5'       � �� . 6>   �� 5(       �@��PanningMode$
 Both=�69   �� 5)       �@��IsFlicksEnabled .  67   �� 5*       �@ AutoGenerateColumns .  64   �� 5+       �@ HeadersVisibility$ Column=�62   �� 5,       � ��$ 0, 10, 0, 0q�6'   �� 5-       �@ SelectionMode$ Single=�6.   �� 5.       �@ SelectionUnit$ FullRow=�6.   �� 5/       �@ CanUserAddRows .  6/   �� 50       �@ CanUserDeleteRows .  62   �� 51       �@ CanUserResizeRows .  62   �� 52       �@ CanUserReorderColumns .  66   �� 53       � ��$ 13(�6)   �� 54       �@ ColumnWidth$ * 6,   �� 55       �@ GridLinesVisibility$
 None=�64   �� 56       � �� 57      �� 58      "  6&   .R�59      �� #��z��6!   #��z��6K   #��z��6w   # z��6�    . ._�5:      �� $ DG_ScrollViewer��6+   |�.  ��5;   "   �� 5<   &   " ��66   .R�5=   *   �  5>   .   �� 5?   2   $
��Auto �6C   �� 5@   2   $��* �6C   �� 5A   2   $
��Auto �6C    5C   .   �� 5D   2   $
��Auto �6@   �� 5E   2   $��* �6@   �� 5F   2   $
��Auto �6@   .+�5H   .   �� #��Z 65   |�.  ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5I   .   $! PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z # Z  �� "  �� 5J   .   $! PART_ScrollContentPresenter��6E   # z��6j   $��2��6�   $��1��6�   �� 5K   .   $  PART_VerticalScrollBar��68   $��2��6X   #" z! 6h   $# Vertical=�6�   $��1��6�   #% z$ 6  #y�z& 6H  ' 6�   �� *VerticalOffset+$( OneWay=� �� *TemplatedParent+6H  � 5L   .   $��1��63   $��2��6C    5M   2   �� 5N   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5O   6   $��* �6G   .+�5Q   2   �� $  PART_HorizontalScrollBar��6<   $��1��6^   #" z) 6n   $# 
Horizontal=�6�   #% z* 6  #y�z+ 6C  ' 6�   �� *HorizontalOffset+$( OneWay=� �� *TemplatedParent+6C  5R   /   5S   +   5T   '   .��5V   "   �� # z 61   5W      5X      5Y      5[      , 5\      ]� 5]      - 5^      �� 5_      . �@��
IsGrouping/ . 6:   �� 5`      ". �@%�IsVirtualizingWhenGrouping/ .  6\   ./�5b      ��  � �� .  6F   5c      5e      �� 5f   
   " n�61   .�5g      ��  � ��$ 8��6&   �� 5h       � ��
 ���� 6+   �� 5i       �@�Cursor$ SizeWE��6'   �� 5j       � �� 5k      �� 5l      " n�6&   .R�5m      �� #��z��6!   # z��6K   5n      5p      5q      �� 5r   
   "  63   .�5s      ��  � ��$ Center=�69   �� 5t       � ��
 ���� 6+   �� 5u       � �� �#D5D0C56+   �� 5v       � ��$ 
15 0 15 10q�6'   �� 5w       � �� 5x      �� 5y      "  6&   .R�5z      � .+�5{        #��z��69   #��z��6c   #��z��6�   #0 z��6�   #2 z1 6�   #4 z3 6  # z��6A  #6 z5 6e  #8 z7 6�  #: z9 6�  ._�5|   "   �� #��z��63   ��. # z 6�   #��z��6�   5}      n� 5~      $; PART_LeftHeaderGripper��6$   $
��Left=�6D   8��  6_   n� 5      $; PART_RightHeaderGripper��6$   $��Right=�6E   8�� 6a   5�      5�      5�      5�      �� 5�   
   "  6+   .�5�      ��  � ��
 ���� 6+   �� 5�       � ��$ Center=�62   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       � ��$ 15, 0q�6'   �� 5�       � �� 5�      �� 5�      "  6&   .R�5�      �� #��z��6!   $��0q�6K    . ._�5�      �� # z 6/   5�      5�      5�      5�      �� 5�   
   "  6*   .�5�      ��  � �� �#3F434D6+   �� 5�       � ��$ 
0, 4, 0, 0q�6'   �� 5�       �@J�SnapsToDevicePixels . 64   �� 5�       �@=�ErrorTemplate 69   Z� �� 5�       �@ ValidationErrorTemplate 5�      �� 5�      .R�5�      �� 
���  ��$��2,0,0,0q�65   $��!��6F   $��Center=�6O   5�      5�      �� 5�       � �� 5�      �� 5�      "  6&   .R�5�      �� $< 
DGR_Border��6!   $
 0, 8q�65   #��z��6D   $= 5��6n   $��0q�6    . ._�5�      	   5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $��* �67    5�   "   �� 5�   &   $��* �64   �� 5�   &   $
��Auto �64   .+�5�   "   
  $��1��69   #��z> 6I   # z 6s     5�   "   $��1��6;   $��1��6K   #y�z? 6o  @ 6X   �� *AreRowDetailsFrozen+# ZA # ZB  �� "  6o    5�   "   $��2��64   $@ Vertical=�6E   y�6�   �� *HeadersVisibility+# ZC # Z  �� "  5�      5�      5�      5�      , 5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � �� �#94979C63   �� 5�       � �� �#ffffff63   5�      P� 5�       �@ 
IsSelected . . �5�      ��  � �� �#94979C63   �� 5�       � �� �#ffffff63   5�      ]� 5�      - 5�      �� 5�      . �@ 
IsSelected/ . 6:   �� 5�      . �@��IsSelectionActive/ .  6J   ./�5�      ��  � �� �#dfdfdf63   5�      5�      �� 5�   
   " ��6'   .�5�      ��  � �� �#1D20286+   �� 5�       � �� �#1D20286,   �� 5�       � �� �#fff6+   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       � ��$ Center=�62   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� #��z��6!   $= 5��6K   $ 5q�6\   $��1q�6h   #��z��6|   ._�5�      �� $��Center=�6/   $��Center=�6L   5�      5�      5�      , 5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � �� �#2A2F3A63   5�      5�      �� 5�   
   " ��6)   8D   .�5�      ��  � �� �#d32f2f6+   �� 5�       � �� �#b71c1c6,   �� 5�       � ��$ 10, 0, 0, 0q�6'   , 5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � �� �#f4433663   5�      5�      �� 5�   
   "  6$   .�5�      ��  � ��$ 12��6&   �� 5�       � ��$ 12��6'   �� 5�       � ��$ Center=�62   5�      �� 5�   
   " ��6"   .�5�      ��  � ��
 ���� 6+   �� 5�       � �� �#D5D0C56+   �� 5�       � ��$ 30��6&   �� 5�       � ��$ 30��6'   �� 5�       � ��$
 Left=�64   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� 
������ ._�5�      �� $��Center=�6/   $��Center=�6L   5�      5�      5�      , 5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � �� �#E1DED663   5      5     �� 5  
   " ��6#   .�5     ��  � ��
 ���� 6+   �� 5      � �� �#D5D0C56+   �� 5      �@�FocusVisualStyle 61   Z� �� 5      � ��$ 20��6'   �� 5      � ��$ 19, 0, 0, 0q�6'   �� 5	      � ��$ 18(�6)   �� 5
      � �� 5     �� 5     " ��6&   .R�5     �� 
������ ._�5     �� $
��left=�6/   $��Center=�6J   5     5     5     , 5     P� 5      �@J�IsMouseOver . . �5     ��  � �� �#E1DED663   5     5     �� 5  
   " ��6!   .�5     ��  � ��
 ���� 6+   �� 5      � ��
 ���� 6+   �� 5      �@�FocusVisualStyle 61   Z� �� 5      � ��$ 0q�60   �� 5      � ��$ 0q�6(   �� 5       � �� 5!     �� 5"     " ��6&   .R�5#     �� 
������ ._�5$     �� $��Center=�6/   $��Center=�6L   5%     5&     5(     , 5*     P� 5+      �@J�IsMouseOver . . �5,     ��  � ��
 ���� 63   5-     50     �� 52  
   " ��6&   .�53     ��  � ��
 ���� 6+   �� 54      � ��
 ���� 6,   �� 55      � ��$ 8q�6(   56     �� 58  
   " ��6   8D   6&   5:     5;     