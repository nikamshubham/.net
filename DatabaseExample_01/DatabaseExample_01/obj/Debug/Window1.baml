   M S B A M L   `   `   `  ����M  IDatabaseExample_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DatabaseExample_01DatabaseExample_01  5   	        DatabaseExample_01.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DatabaseExample_01     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � $��0,-1,0,1q�6   .+�5
   
   �� -   5         ��Name$ btnExecuteScalar��5
      $��Execute Scalar��6+   $
��Left=�6D   $��
344,32,0,0q�6_   $	��Top=�6s   $	��113��6�   6�   �� 5   
   -   5        $ btnDataReader��5      $��Data Reader��6(   $
��Left=�6>   $��
344,71,0,0q�6Y   $	��Top=�6m   $	��100��6�   6�   �� 5   
   -   5         ��Name$ lstEmployee��5      $
��Left=�6'   $	��147��6B   $��	91,32,0,0q�6O   $	��Top=�6b   $	��178��6z   �� 5   
   -   5        $ btnExecuteReader��5      $��Execute Reader��6+   $
��Left=�6D   $��344,111,0,0q�6_   $	��Top=�6t   $��98��6�   6�   �� 5   
   -   5        $ btnMARS��5      $
��MARS��6"   $
��Left=�61   $��344,148,0,0q�6L   $	��Top=�6a   $	��101��6y   6�   �� 5   
   -   5        $ btnDataReadFromFunction��5      $��Data Read From Function��62   $
��Left=�6T   $��334,187,0,0q�6o   $	��Top=�6�   $	��150��6�   6�   5      5      