   M S B A M L   `   `   `  ����K  GNorthenLightHosp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:NorthenLightHospNorthenLightHosp  5   	   #    NorthenLightHosp.AccueilAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:NorthenLightHosp     5   	     � Title$  AccueilAdmin��5   	   $��318.28��6   $��456.989��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $*��$Tableau de bord NorthenLightHospital��6   $
��Left=�6N   $��	10,10,0,0q�6i   $	��Top=�6|   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgEmployes��5      $
��Left=�6'   $��
152,41,0,0q�6B   $	��Top=�6V   $	��238��6n   $	��288��6{      AutoGenerateColumns .     
IsReadOnly .    CanUserSortColumns .  ��5      ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Prenom��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *prenom+  5      $	 Nom��6%    62   �� *nom+5      �� 5   
   -   5        	 ��Name$	 cbxRole��5      $
��Left=�6$   $��	10,41,0,0q�6?   $	��Top=�6R   $	��127��6j   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�5       �� DisplayMemberPath$ designation��6P    �� SelectedValuePath$ id��5   ?   ��5   8   �� 5   ?   �� 5   
   -   5         ��Name$ btnModifier��5      $��Modifier��6&   $
��Left=�69   $��	10,68,0,0q�6T   $	��Top=�6g   $	��127��6   {�.  6�   �� 5   
   -   5        $ btnSupprimer��5      $��	Supprimer��6'   $
��Left=�6;   $��	10,92,0,0q�6V   $	��Top=�6i   $	��127��6�   {�.  6�   �� 5   
   -   5        $ 
btnAjouter��5      $��Ajouter��6%   $
��Left=�67   $��
10,116,0,0q�6R   $	��Top=�6f   $	��127��6~   6�   �� 5   
   -   5        $ 
btnPatient��5      $��Liste des patients��6%   $
��Left=�6B   $��
10,187,0,0q�6]   $	��Top=�6q   $	��127��6�   6�   5      5      