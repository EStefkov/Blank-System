   M S B A M L   `   `   `  ����D  @BLANKMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BLANKMenu.ViewsBLANKMenu.Views  5   	   !    BLANKMenu.Views.TableWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   
   )localclr-namespace:BLANKMenu.Views  5   	     � Title$  TableWindow��5	   	   $
��1920��6   $
��1080��6+    � WindowStyle$
 None=�5
   	    � WindowState$ 	Maximized=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 50��6    J� Opacity$
 0.98Q�5   	   $��15q�5   	   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �    winBorderColor1 � Color# [  6   	 � Offset$	 0Q�6H   � 5        winBorderColor2# [ 6   $
	 0.75Q�6H   � 5        winBorderColor3# [ 6   $	 1Q�6H   5      ��5   
   �� 5      $	 0,0&�6"   $ 1,0.7&�63   .��5      �   primaryBackColor1# [ 6   $	 0Q�6J   � 5        primaryBackColor2# [ 6   $
	 0.75Q�6J   5      ._�5   
   � 
 � RowDefinitions
 5      �� 5       $��90 �6    �� 5"      $��* �6    �� 5#      $	��200 �6    .+�5%      � $��1��6    � ColumnDefinitions 5&      �� 5'      $	��600 �6'   �� 5(      $��* �6'   .+�5,      �� $��0��6   $ 50��5-      $��40,0,0,0q�5.      ��50      �� 51      $	 0,0&�6.   $	 1,0&�6?   .��52      � # [  6+   $	 1Q�6T   � 53      # [ 6+   $	 0Q�6T   54      56      �� 57      $��2��6   $ 50��58      $��0,0,50,0q�59      5<      �� 5=      $��1��6   $ 50��5>      $��	10,0,10,0q�5?      ���#1607545C      �� 5D      $��1��6   $��0��6&   $��40,0,0,0q�5E      ._�5F      �� $��0,50,0,0q�5G      .+�5H      �� $ 20��6!   $
 0.98Q�5I      $��15q�5J      ��5K      �� 5L   "   $	 0,0&�66   $	 1,0&�6G   .��5M   &   � # [  63   $	 0Q�6\   � 5N   &   # [ 63   $	 1Q�6\   5O   #   ._�5R      �� $��	HISTORY  ��6(     plainTextColor2#��[ 5S       $��20(�5T        � Cursor$
 Hand��5U       $��
Montserrat)�5V       $��Center=�5W       $��Center=�5X       ��5Y      �� 5Z   "   $	 0,0&�66   $ 1,0.7&�6G   .��5[   &   � # [ 63   $	 0Q�6^   � 5\   &   # [ 63   $
	 0.75Q�6^   5]   #   5_      5`      5a      �� 5b      $��1��6   $��1��6&   $��	10,0,10,0q�5c      ._�5d      �� $��0,50,0,0q�5e      .+�5f      �� $ 20��6!   $
 0.98Q�5g      $��15q�5h      ��5i      �� 5j   "   $	 0,0&�66   $	 1,0&�6G   .��5k   &   � # [  63   $	 0Q�6\   � 5l   &   # [ 63   $	 1Q�6\   5m   #   ._�5p      �� $
��MENU��6(   #��[ 5q       $��20(�5r       $
 Hand��5s       $��
Montserrat)�5t       $��Center=�5u       $��Center=�5v       ��5w      �� 5x   "   $	 0,0&�66   $ 1,0.7&�6G   .��5y   &   � # [ 63   $	 0Q�6^   � 5z   &   # [ 63   $
	 0.75Q�6^   5{   #   5}      5~      5      5�      �� 5�      $��/images/logo.png��6   $��0��6.   $	��100��6;   $
��Left=�6H   �� 5�      $��0��6    �� Orientation$ 
Horizontal=�5�      $��Center=�5�      $��	100,0,0,0q�5�      .+�5�      �� $��BLANK SYSTEM ��6     plainTextColor1#��[ 5�       $��16(�5�       $��
Montserrat)�5�       $��Center=�5�       5�      	� 5�      -   5         	�Name$ newTableButton��5�        
menuButton#��[ 62   $��Right=�6V   $��2��6r    
 color1
 � Tag# [ 6   $��0,0,10,0q�6�   ��5�      �� *LogoutCommand+.��5�      �� $ Vertical=�6   .+�5�      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6#    	 menuButtonIcon#��[	 60   �� 5�      $
��EXIT��6     
 menuButtonText#��[
 6,   $��Center=�6T   $��0,5,0,0q�6r   5�      5�      5�      5�      5�      