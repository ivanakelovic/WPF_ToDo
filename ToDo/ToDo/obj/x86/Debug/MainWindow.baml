   M S B A M L   `   `   `  ����  ToDo    ToDo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��480��6   $	��297��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z    � AllowsTransparency . ��6m   Z� .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5	      $��70 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��label1��5   L   $��My TODOs��6   $��35��6#   $��Center=�6/   $��Center=�6Z   $��3��6v   $��18(�6�   $
��Bold"�6�   �� 5   
   
�������$��2��6)   $��28��69   $��20��6E   $	��Top=�6P   $��Right=�6h   
���   �$��1q�6�    �� CornerRadius$ 10��6�   ._�5      �� -   5        $��
lblZatvori��5   #   $��X��6   65   5      �� 5   
   $��3��6   $��1��6+   $
��Auto=�68   .��5      �� -   5        $��	spObaveza��5      5      �� 5   
   -   5        $��btnZavrsene��5   H   $��2��6   $��60��6   $��Center=�6*   $��Center=�6[   $��60��6v   ��5      �� 5       �� ImageSource$( "/ToDo;component/Images/checked.png��6   5      �� 5   
   -   5        $��btnDodaj��5   Y   $��1��6   $��2��6"   $��60��6/   $��Center=�6;   $��Center=�6i   $��60��6�   ��5      �� 5      $$ /ToDo;component/Images/add.png��6   5       �� 5!   
   -   5        $��btnNeZavrsene��5!   X   $��2��6   $��2��6!   $��60��6.   $��Center=�6:   $��Center=�6m   $��60��6�   ��5"      �� 5#      $* $/ToDo;component/Images/unchecked.png��6   5%      5&      5'      