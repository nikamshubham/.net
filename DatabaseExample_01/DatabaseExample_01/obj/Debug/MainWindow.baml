   M S B A M L   `   `   `  ����M  IDatabaseExample_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DatabaseExample_01DatabaseExample_01  5   	   #    DatabaseExample_01.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DatabaseExample_01     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblEmpNo��5
      $��Emp No��6"   $
��Left=�63   $��
147,30,0,0q�6N   $	��Top=�6b   �� 5   
   -   5         ��Name$ txtEmpNo��5      $
��Left=�6$   $��23��6?   $��
247,33,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ lblName��5      $
��Name��6!   $
��Left=�60   $��
147,77,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��23��6>   $��
247,80,0,0q�6J   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ lblBasic��5      $��Basic��6"   $
��Left=�62   $��152,127,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ txtBasic��5      $
��Left=�6$   $��23��6?   $��247,130,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ 	lblDeptNo��5      $��Dept No��6#   $
��Left=�65   $��140,175,0,0q�6P   $	��Top=�6e   �� 5   
   -   5        $ 	txtDeptNo��5      $
��Left=�6%   $��23��6@   $��247,175,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -	   5         ��Name$ 	btnInsert��5      $��Insert��6$   $
��Left=�65   $��140,233,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -
   5        $ btnPreparedStatement��5      $$��Insert With Prepared Statement��6/   $
��Left=�6X   $��
75,268,0,0q�6s   $	��Top=�6�   $	��189��6�   6�   �� 5   
   -   5        $ btnStoredProcedure��5      $"��Insert With Stored Procedure��6-   $
��Left=�6T   $��
82,303,0,0q�6o   $	��Top=�6�   $	��182��6�   6�   �� 5   
   -   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��345,233,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $  btnUpdatePreparedStatement��5      $!��UpdateWithPreparedStatement��65   $
��Left=�6[   $��295,268,0,0q�6v   $	��Top=�6�   $	��178��6�   6�   �� 5   
   -   5        $!��ButtonUpdateStoredProcedure��5      $
��Left=�67   $��296,303,0,0q�6R   $	��Top=�6g   $	��177��6   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��568,233,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $$ btnDeleteWithPreparedStatement��5      $$��Delete With Prepared Statement��69   $
��Left=�6b   $��514,268,0,0q�6}   $	��Top=�6�   $	��188��6�   6�   �� 5   
   -   5        $" btnDeleteWithStoredProcedure��5      $"��Delete With Stored Procedure��67   $
��Left=�6^   $��524,303,0,0q�6y   $	��Top=�6�   $	��178��6�   6�   5      5      