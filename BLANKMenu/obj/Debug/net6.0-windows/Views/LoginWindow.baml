   M S B A M L   `   `   `  ����D  @BLANKMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BLANKMenu.ViewsBLANKMenu.Views  5   	   ;"clr-namespace:BLANKMenu.ViewModelsBLANKMenu.ViewModels  5   	   C&clr-namespace:BLANKMenu.CustomControlsBLANKMenu.CustomControls  5   	       BLANKMenu.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BLANKMenu.Views     5   	   8	viewModel"clr-namespace:BLANKMenu.ViewModels     5   	   Acustomcontrols&clr-namespace:BLANKMenu.CustomControls     5   	   -   5          � Title$  Blank System��5
   	   $	��550��6   $	��800��6+    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      )   #BLANKMenu.ViewModels.LoginViewModel  5   
    � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6'   5      y�5      �� 5   
    �� Path$ IsViewVisible�6    �� Mode$ TwoWay=�6'   	 �� 	Converter#	 [  65   .��5      �� 
 �� CornerRadius$
 15��6    J� Opacity$
 0.95Q�5      $��5q�5       ��5!      �� 5"       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5#      �   winBorderColor1 � Color# [ 6#    � Offset$ 0Q�6L   � 5$        winBorderColor2# [ 6#   $
 0.75Q�6L   � 5%        winBorderColor3# [ 6#   $ 1Q�6L   5&      ��5(      �� 5)      $ 0.1,0.7&�6&   $	 1,0&�6;   .��5*      �   primaryBackColor1# [ 6#   $ 0Q�6N   � 5+        primaryBackColor2# [ 6#   $
 0.75Q�6N   5,      ._�5/      �  � RowDefinitions 50      �� 51      $��30 �6$   �� 52      .+�55      �  � ColumnDefinitions 56      �� 57      �� 58      $��25 �6+   �� 59      $��25 �6+   �� 5:      $��10 �6+   .+�5=      �� $��LOG IN��6      plainTextColor1#��[ 5>       $��15(�5?       $��
Montserrat)�5@       $��0��5A       $��Center=�5B       $��10,0,0,0q�5C       �� 5E      -   5         ��Name$ btnMinimize��5E      $��0q�5F      $��-��5G      
�������$��16(�5I      $��
Montserrat)�5J       � Cursor$
 Hand��5K      $��1��5L      ��5N      �� 5O       �� 
TargetType" ��6$   .�5P   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5Q   "   P� 5R   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5S   *   ��  � �� �#278BEF6G   5T   '   5V      ��5X      �� 5Y       �� 
TargetType" ��6.   .R�5Z   "   �� $��18��6)   $��18��64   $
 9��5[   )   #��z��5\   )   ._�5]   &   �� $��Center=�67   $��Center=�6R   5^   #   5_      5a      �� 5c      -   5        $ btnClose��5c      $��0q�5d      $��X��5e      
�������$��12(�5g      $��
Montserrat)�5h      $
 Hand��5i      $��2��5j      ��5l      �� 5m      " ��6$   .�5n   "   ��  � �� �#DA34AE6?    5o   "   P� 5p   &    �@J�IsMouseOver$
 True��6E   . �5q   *   ��  � �� �#C62DAE6G   5r   '   5t      ��5v      �� 5w      " ��6.   .R�5x   "   �� $��18��6)   $��18��64   $
 9��5y   )   #��z��5z   )   ._�5{   &   �� $��Center=�67   $��Center=�6R   5|   #   5}      5      5�      �� 5�      $	��250��6   $��2��5�       �� Orientation$ Vertical=�5�      $��0,0,0,0q�5�      .+�5�      �� $��/images/logo.png��6   $	��250��62   $	��238��6>   6M   �� 5�      $��Blank System��6     titleColor1#��[ 5�      $��25(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��Center=�5�      $��Center=�5�      �� 5�      $��Always with you��6   
�������$��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      $
��Wrap=�5�       �� TextAlignment$ Center=�5�      $��0,5,0,0q�5�      �� 5�      $��Username��6   
�������$��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      $
��Wrap=�5�      $��0,5,0,0q�5�      �� 5�      -   5         ��Name$ txtUser��5�      $��13(�5�      $��Medium"�5�      
������ $��	Motserrat)�5�      
������� �� 
CaretBrush
 �����
�������$��0,0,0,1q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��0,0,0,0q�5�      ��5�      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�.��5�   ,   5�      �� 5�      $��Password��6   
�������$��12(�5�   !   $��Medium"�5�   !   $��
Montserrat)�5�   !   $
��Wrap=�5�   !   $��0,15,0,0q�5�   !   2   ,BLANKMenu.CustomControls.BindablePasswordBox  5�      $��28��5�   5   $��0,5,0,0q�5�   5       Password  5�   5   �� *
Password+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      ���#D7596D$��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��0,0,0,0q�5�      $
��Wrap=�5�      ��5�      �� *ErrorMessage+5�      �� 5�      -   5        $ btnLogin��5�      $��0q�5�      $��LOG IN��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,30,0,0q�5�      ��5�      �� *LoginCommand+��5�      �� 5�      " ��6    .�5�      ��  � �� �#462AD86;    5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �#28AEED6C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $	��150��6%   $��40��61   $
 20��5�      #��z��5�      ._�5�   "   �� $��Center=�63   $��Center=�6N   5�      5�      5�      5�      5�      5�      5�      