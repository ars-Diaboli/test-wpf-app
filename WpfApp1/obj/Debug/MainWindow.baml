   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   B >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1 5   	   1clr-namespace:WpfApp1.ToolkitWpfApp1.Toolkit 5   	      WpfApp1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   'localclr-namespace:WpfApp1     5   	   6localToolkitclr-namespace:WpfApp1.Toolkit     5   	     � Title$  
MainWindow��5
   	   $	��360��6   $	��600��6,      WindowStyle#���   6;    � 	Resources 5        WpfApp1.SelectedDirectory  SelectedDirectory �� 
TargetType  navBtnTemplate ��Name �� CornerRadius �� Triggers P� Property P� Value �� Property	 �� Value
 �� 
TargetName��%�  &	       &	        5      6   �� 5      " ��6   .R�5      �� $ buttonBorder��6   $ 15��6"   
�����_�$��2q�6L   
������ $��30��6y   ._�5      �� $��5q�6   $��Center=�6    $��Center=�6=   #��z��6X   5       5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$
	 Bold"�6$   5      P� 5       � �� . . �5      �� $
 buttonBorder��6    � ��
	 �����6>   �� 5      $
 buttonBorder��6    � ��
	 ��  �6?   5      P� 5       � {� .  . �5      ��  � ��
	 �����6$   �� 5      $
 buttonBorder��6    � ��
	 �����6>   5      5      5      .��5       ]� .+�5!      o� $	��Top=�6	   $��Stretch=�6     	MenuStyle#���  6<   .@�5"      m� $
��File��6   6   m� 5#      $
��Edit��6   6   m� 5$      $
��View��6   .@�5%      m� -   5         m�Name$ ThemeSelector��5%      $��Theme��6   5&      5'      m� 5(      $��Tools��6   6   m� 5)      $
��Help��6   6   5*      ]� 5+      $	��Top=�6     ControlDockStyle#���  6#   .+�5,      �� $
��Left=�6   $
��Back��6"     PanelButtonStyle#���  61   #��[ 6\   �� 5-      $
��Left=�6   $��Up��6"   #���  6/   #��[ 6Z   �� 5.      -   5         ��Name$ DirectoryPath��5.      $
��Left=�6s     DirectoryPathStyle#���  6�    �� TextWrapping$
 Wrap=�6�   ��6$   ��  �� Source# [  �� Path$ DirectoryPath�6�   5/      �� 51      $��Bottom=�6     StatusBarStyle#���  6&   .@�52      �� 
123456786   53      �� 55      $��Bottom=�6    �� Orientation$ 
Horizontal=�6'   $��0,0,0,10q�6@   .+�56      �� $��Button��6   $
��Left=�6   $��10,0,0,0q�68   $	��Top=�6J   $��75��6b   �� 57      $��Button��6   $
��Left=�6   $��10,0,0,0q�68   $	��Top=�6J   $��75��6b   58      � 5:       � ColumnDefinitions 5;      �� 5<      $��1* �6   $��80��6"   �� 5=      $
��Auto �6   �� 5>      $��3* �6   $��80��6"   .+�5@      R� -   5         R�Name$ foldersTree��5@      $��0��6   ��5B      �� $
 Root���5C      �� 5D       �� ItemsSource 6    �� $ Items�.R�5E      �� $ 
Horizontal=�6   .+�5F   	   �� $��16��6   $��16��6   $	��3,0q�6&   ��63   �� $
 Icon��� 5G   	   ��6   �� *Name+5H   	   5I      5K      �� 5L      $��1��6   $��5,8,5,8q�6"    �� ResizeBehavior$ PreviousAndNext=�63   $��5��6T    �� ShowsPreview .  $��Stretch=�6s   &   System.Windows.Controls.DataGrid  5M      $��2��6   6!   5N      5P      5Q      