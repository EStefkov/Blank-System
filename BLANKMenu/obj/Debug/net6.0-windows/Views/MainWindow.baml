   M S B A M L   `   `   `  ����D  @BLANKMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BLANKMenu.ViewsBLANKMenu.Views  5   	   ;"clr-namespace:BLANKMenu.ViewModelsBLANKMenu.ViewModels  5   	        BLANKMenu.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   )localclr-namespace:BLANKMenu.Views  5   	   2	viewModel"clr-namespace:BLANKMenu.ViewModels  5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStyle$
 None=�5   	    � WindowState$ 	Maximized=�5   	   
������  � AllowsTransparency$
 True��5   	    � 	Resources 5      *   $BLANKMenu.ViewModels.TablesViewModel   tablesViewModel��%   &	          5   
   6$   5       � DataContext 5      (   "BLANKMenu.ViewModels.MainViewModel  5   
   .��5      ��  �� CornerRadius$ 50��6    J� Opacity$
 0.98Q�5      $��15q�5       ��5!   
   �� 5"       �� 
StartPoint$	 0,0&�6"   	 �� EndPoint$		 1,1&�63   .��5#      �   winBorderColor1
 � Color#
 [ 6    � Offset$ 0Q�6H   � 5$        winBorderColor2#
 [ 6   $
 0.75Q�6H   � 5%        winBorderColor3#
 [ 6   $ 1Q�6H   5&      ��5(   
   �� 5)      $	 0,0&�6"   $	 1,0.7&�63   .��5*      �   primaryBackColor1#
 [ 6   $ 0Q�6J   � 5+        primaryBackColor2#
 [ 6   $
 0.75Q�6J   5,      ._�51   
   �  � RowDefinitions 52      �� 53      $��90 �6    �� 55      $��* �6    �� 56      $��90 �6    .+�5;      �� $��/images/logo.png��6   $��0��6.   $	��100��6;   $
��Left=�6H   � 5<      $��1��6   .+�5A      �� # [  6   ��6J   �� *Tables+ �� View 5B      �� 5C      .P�5D      �� $��Table Number��6-    �� DisplayMemberBinding 6C   �� *TableNumber+�� 5E      $��Seats��6-    6<   �� *NumberOfSeats+�� 5F      $��Status��6-    6=   �� *Status+5H      5J      5M      	� 5O      -   5         	�Name$ newTableButton��5O        
menuButton#��[ 62   $��Right=�6V   $��2��6r    
 color1
 � Tag# [ 6   $��0,0,10,0q�6�   ��5P      �� *LogoutCommand+.��5Q      ��  �� Orientation$ Vertical=�6   .+�5R      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6#     menuButtonIcon#��[ 60   �� 5S      $
��EXIT��6     	 menuButtonText#��[	 6,   $��Center=�6T   $��0,5,0,0q�6r   5T      5U      �� 5W      $��2��6   $��Center=�6&   .+�5Y      �� -   5         ��Name$ TableNumberTextBox��5Y       � ToolTip$3 -Въведете номер на масата��66   �� 5\      -   5        $ NumberOfSeatsTextBox��5\      $* $Въведете брой места��68   �� 5_      $��Потвърди��6   ��6,   �� *AddTableCommand+5`      � 5d      $��0��6    � ColumnDefinitions 5e      �� 5f      �� 5g      .+�5k      �� $��0��6   $ 
Horizontal=�5l      $��Center=�5m      $��	100,0,0,0q�5n      .+�5o      �� $��Your Bar Name ��6     
 plainTextColor2#��[
 5p       $��16(�5q       $��
Montserrat)�5r       $��Center=�5s       5t      �� 5v      $��1��6   $ 
Horizontal=�5w      $��RightToLeft=�5x      $��Center=�5y      $��0,0,10,0q�5z      .+�5~      ��   
iconButton#��[ 6   # [ 5      .��5�        $ 	AngleDown=�6'     IconButtonIcon#��[ 68   5�      �� 5�        titleColor2#��[ 5�   (   $��
Montserrat)�5�   (   $��12(�5�   (   $��Center=�5�   (   ��5�       �� * CurrentUserAccount.DisplayName+5�   (   A� 5�      $��35��6   $��35��6*    
 color2#��[ 5�   &   $��2��5�   &   $��	10,0,10,0q�5�   &   ��5�      �� 5�       �� ImageSource$ /images/logo.png��6)   5�      5�      5�      5�      5�      5�      