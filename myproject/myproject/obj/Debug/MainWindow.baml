   M S B A M L   `   `   `  ����D  @myproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:myproject	myproject  5   	       myproject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:myproject     5   	     � Title$  
MainWindow��5   	   $��481.509��6   $��604.852��6-   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0,9,0,-9q�6   .+�5      �� -   5        $��scroll��5      ��. $
��Auto��6A   $	��350��6O   .��5      �� -   5         ��Name$ workers��5      ��5      �� 5      .R�5      �� $��10q�6)    �� Orientation$ 
Horizontal=�65   .+�5   "   �� $��16(�6,   $
��Left=�6V   $��10 0 0 0q�6q   ��6;   ��  �� Path$
 Name�6q   �� 5   "   $��16(�6*   $��Center=�6W   $��10 0 0 0q�6t   ��68   �� $ Position�6t   �� 5   "   $��16(�6,   $��Right=�6U   $��10 0 0 0q�6q   ��6;   �� $	 Age�6q   �� 5   "   $��16(�6*   $��Center=�6X   $��10 0 0 0q�6u   $	��100��6�   ��68   �� $ 	Datastart�6�   �� 5   "   $��16(�6*   $��Center=�6Z   $��10 0 0 0q�6w   $	��100��6�   ��69   �� $ 
Datefinish�6�   �� 5   "   -   5        $��Delete��5   )   $��70��6:   $��20 0 0 0q�6H   $��80��6f   5      5      5      5!      5"      �� 5#   
   $��1��6   $��0 15 0 0q�6#   .+�5%      �� -   5        $	��100��5%      $��30��6!   $	��Add��6-   $��0 0 0 5q�6L   �� 5&      -   5        $	��100��5&      $��30��6!   $��Refresh��6-   6?   5'      5(      5)      