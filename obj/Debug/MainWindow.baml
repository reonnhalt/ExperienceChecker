   M S B A M L   `   `   `  ����B  >Akatuki, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AkatukiAkatuki  5   	       Akatuki.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Akatuki     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��800��6)   .��5	      � .+�5
   
   �� $��60��6   $��10,40,9.6,0q�6!    �� Orientation$ 
Horizontal=�66   $	��Top=�6O   .+�5      �� -   5         ��Name$ title��5      $��経験値チェッカー��6#   $	��297��66   $��36(�6B   �� 5      -   5        $ version��5      $
��v0.1��6%   $��36(�64   5      �� 5   
   $
��Left=�6   $��40��60   $��
10,105,0,0q�6<   $	��Top=�6P   $	��774��6h   $ 
Horizontal=�6t   .+�5      �� -   5        $ label��5      $��ランクを選択��6#   $��20(�64   $	��135��6B   �� 5      -   5         ��Name$
 Lank��5      $	��100��6%   $��
0,0,0,-0.4q�61    �� DisplayMemberPath$ 	disp_rank��6k   ��6E   �� *CharacterRank+6k   �� 5      -   5         ��Name$ button��5      $��計算��6%   $��75��62   $��20(�6=   $��	200,0,0,0q�6K   5      �� 5   
   -   5        $ result��5      $��計算結果��6    $
��Left=�6/   $��
10,150,0,0q�6J   $	��Top=�6^   $��20(�6v   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
10,196,0,0q�6@   $	��Top=�6T      AutoGenerateColumns .  $	��774��6�   $	��166��6�   5      5      