   M S B A M L   `   `   `  ����>  :pr4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:pr4pr4  5   	       pr4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:pr4     5   	     � Title$  
MainWindow��5   	   $	��640��6   $	��800��6)   .��5	      � .+�5
   
   ]� ��. .+�5      �� $	��100��6   $
��Left=�6(   .+�5      �� $��Center=�6   Editing Mode6G   �� 5      -   5         ��Name$ btnSelection��5      $��5q�6/   .��6:   	Selection6E   �� 5      -   5        $ btnDraw��5      $��5q�6*   .��65   Draw6;   �� 5      -   5        $ btnErase��5      $��5q�6+   .��66   Erase6=   �� 5      $��Center=�6   Choose Color6G   �� 5      -   5         ��Name$ rectRed��5      
���  ��$��50��68   $��5q�6G   6T   �� 5      -   5        $ 
rectOrange��5      
��� ���$��50��6>   $��5q�6M   6Z   �� 5      -   5        $ 
rectYellow��5      
��� ���$��50��6>   $��5q�6M   6Z   �� 5      -   5        $ 	rectGreen��5      
��� � �$��50��6<   $��5q�6K   6X   �� 5      -   5        $ rectCyan��5      
����� �$��50��6:   $��5q�6I   6V   �� 5      -	   5        $ rectBlue��5      
����  �$��50��6:   $��5q�6I   6V   �� 5      -
   5        $ 
rectPurple��5      
���� ��$��50��6>   $��5q�6M   6Z   �� 5      -   5        $ 	rectBlack��5      
���   �$��50��6<   $��5q�6K   6X   5      �� 5      -   5         ��Name$ 
InkCanvas1��5       �� EditingMode$	 Ink=�6,   }�. 5      5      5      5      