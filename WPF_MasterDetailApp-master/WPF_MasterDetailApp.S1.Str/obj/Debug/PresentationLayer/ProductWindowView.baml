   M S B A M L   `   `   `  ����N  JWPF_MasterDetailApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:WPF_MasterDetailApp.PresentationLayer%WPF_MasterDetailApp.PresentationLayer  5   	   +    %WPF_MasterDetailApp.ProductWindowView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:WPF_MasterDetailApp.PresentationLayer     5   	   -   5          �Name$  
ListWindow��5   	    � Title$ Master Guitar��5   	   $	��500��5	   	   $	��900��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         DetailLabelStyle �� 
TargetType �� Property �� Value  DetailTextBoxStyle��%�   &	        &	 t     �� 5   
   " ��6)   .�5      ��  � ��$ Right=�64   �� 5       � ��$ 0,0,0,0q�6'   5      �� 5   
   " ��6+   .�5      ��  � ��$ 0,5,0,5q�6'   5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��5      
 �� Orientation$
 Vertical=�5      .+�5!   
   �� ��5"      �� *CompanyInfo.Name+5#      � 5$   
   $��1��5%       � ColumnDefinitions 5'      �� 5(      $��* �6#   �� 5)      $��* �6#   �� 5*      $��* �6#   .+�5,      �� $��1��5-      $��0,0,0,60q�5.      $	��Top=�5/      $��Center=�50      ��51      �� *SelectedProduct.ImageFilePath+�� 52      ��6   �� *SelectedProduct.FirstName+�� 53      $��1��54      $
 Vertical=�55      .+�56      �� $��Guitar��6   #��[  57      �� 58      $��Manufacturer��6   #��[  59      �� 5:      $��Manufacturer Year��6   #��[  5;      5=      �� 5>      $��2��5?      $
 Vertical=�5@      .+�5A      �� #��[ 5B      ��5A      �� *SelectedProduct.Guitar+5B      �� 5C      #��[ 5D      ��5C      �� *SelectedProduct.Manufacturer+5D      �� 5E      #��[ 5F      ��5E      �� *!SelectedProduct.ManufactureYear+5F      �� 5G      -   5         ��Name$ _exitButton��5G      $
��Exit��5H      $	��100��5I      $��30��5J      $��Bottom=�5L      64   5N      5O      5P      5Q      