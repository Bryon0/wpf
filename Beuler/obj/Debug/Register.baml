   M S B A M L   `   `   `  ����A  =Beuler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BeulerBeuler  5   	       Beuler.Register   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Beuler     5   	     � Title$  Register��5   	   $	��385��6   $	��405��6'   .��5	      �  J� RenderTransformOrigin$ 0.443,0.461&�6   $��	0,0,19,21q�6/   .+�5
   
   �� -   5         ��Name$ textBoxFirstName��5
      $
��Left=�6,   $��23��6G   $��
139,29,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ textBoxLastName��5      $
��Left=�6+   $��23��6F   $��
139,67,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ textBoxEmail��5      $
��Left=�6(   $��23��6C   $��139,104,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ textBoxPassword��5      $
��Left=�6+   $��23��6F   $��139,142,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ textBoxConfirmPassword��5      $
��Left=�62   $��23��6M   $��139,179,0,0q�6Y   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ textBoxAddress��5      $
��Left=�6*   $��23��6E   $��139,217,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ label��5      $��First Name:��6   $
��Left=�65   $	��Top=�6P   $��	49,26,0,0q�6h   �� 5   
   -   5        $ 	labelLink��5      $
��Left=�6#   $��Bottom=�6>   $ 6.816,2.538&�6Y   $��320,0,0,281q�6}   .��5      ��  �� Command 6   ��  �� Path$ 	LogInUser�.�6;   Login6B   5      �� 5   
   -	   5         ��Name$ button��5      $��Register��6N   $
��Left=�6a   $	��Top=�6|   $	��200��6�   $��105,272,0,0q�6�   ��6!   �� $ RegisterUserCommand�6�   5      5      