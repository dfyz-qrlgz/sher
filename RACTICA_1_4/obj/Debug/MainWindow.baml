   M S B A M L   `   `   `  ����F  BRACTICA_1_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RACTICA_1_4RACTICA_1_4  5   	       RACTICA_1_4.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:RACTICA_1_4     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��19* �6   �� 5      $	��12* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid��5         CanUserAddRows .  $��	5,14,5,49q�6<   6O   �� 5   
   -   5        $
��btn1��5      $!��вторая таблица��6   $
��Left=�66   $��64��6Q   $��
617,25,0,0q�6]   $	��Top=�6q   $	��152��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$
 btn5��5      $#��Добавить автора��6   $
��Left=�69   $��	48,44,0,0q�6T   $��1��6g   $	��Top=�6t   $	��352��6�   6�   �� 5   
   -   5         ��Name$ AthName��5      $
��Left=�6#   $��
131,18,0,0q�6>   $��1��6R    �� TextWrapping$
 Wrap=�6_   $��Имя��6s   $	��Top=�6~   $	��169��6�   $��18��6�   �� 5   
   -   5        $ AthMail��5      $
��Left=�6#   $��18��6>   $��
305,18,0,0q�6J   $��1��6^   $
 Wrap=�6k   $	��Top=�6   $��95��6�   $��
Почта��6�   �� 5   
   -   5        $ Athid��5      $
��Left=�6!   $��18��6<   $��	48,18,0,0q�6H   $��1��6[   $
 Wrap=�6h   $��id автора��6|   $	��Top=�6�   $��78��6�   �� 5   
   -   5        $
 btn3��5      $!��Удалить данные��6   $
��Left=�68   $��	48,69,0,0q�6S   $��1��6f   $	��Top=�6s   $	��352��6�   6�   �� 5   
   -   5        $
 btn7��5      $#��Изменить данные��6   $
��Left=�69   $��24��6T   $��	48,99,0,0q�6`   $��1��6s   $	��Top=�6�   $	��352��6�   6�   5      5      