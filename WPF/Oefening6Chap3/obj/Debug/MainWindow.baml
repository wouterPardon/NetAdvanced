   M S B A M L   `   `   `  ����D  @Oefening6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Oefening6	Oefening6  5   	       Oefening6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Oefening6     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $
��Save��6   �� 5      m� 5      -   5        $��exitMenuItem��5      $
��Exit��6/   6=   5      m� 5      $
��Help��6   .@�5      m� -   5        $��aboutMenuItem��5      $��About��60   6?   5      5      �� 5   
   $��Bottom=�6   $��Bottom=�6-   
�������$��50��6Z   .+�5      �� -   5        $��statusBarTextBlock��5      $��Status bar Message...��62   
�������6O   5      �� 5   
   $	��135��6   
�������$
��Left=�63   $
��Left=�6I   .+�5      �� -   5        $��changeColorButton��5      $	��130��6.   $��30��6:   $��Wijzig kleur��6F   $��5q�6]   6h   �� 5      -   5        $��changeWindowButton��5      $	��130��6/   $��30��6;   $��Versmal venster��6G   $��5q�6a   6l   �� 5      -   5        $��deleteRectanglesButton��5      $	��130��63   $��30��6?   $��Verwijder rechthoken��6K   $��5q�6j   6u   5      � 5   
   -   5        $��rectangleGrid��5       � RowDefinitions 5      �� 5      $��* �6    �� 5       $��* �6     � ColumnDefinitions 5"      �� 5#      $��* �6#   �� 5$      $��* �6#   .+�5&      �� -   5        $��leftTopRectangle��5&      $��0��60   $��0��6@   �� 5'      -	   5        $��rightTopRectangle��5'      $��1��61   $��0��6A   �� 5(      -
   5        $��leftBottomRectangle��5(      $��0��63   $��1��6C   �� 5)      -   5        $��rightBottomRectangle��5)      $��1��64   $��1��6D   5*      5+      5.      