   M S B A M L   `   `   `  ����  EasyCodeM2G    EasyCodeM2G.SalesUser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	SalesUser��5   	   $	��400��6   $	��800��6(   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgView��5   a   $��Stretch=�6   $��
10,80,10,5q�61   $��Stretch=�6E      AutoGenerateColumns .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      CanUserAddRows .     
IsReadOnly . ��6�   ��    Columns 5      5	      �� 5
   
   -   5        $��txtLocalUrl��5
   �   $
��Left=�6   $��22��6-   $��	10,20,0,0q�69    �� TextWrapping$
 Wrap=�6L   $�� ��6`   {�.  $	��Top=�6{   $	��150��6�   6�   �� 5   
   -   5        $��btnLL��5   �   $��浏览��6   $
��Left=�6   $��22��69   $��
170,20,0,0q�6E   $	��Top=�6Y   $��75��6q   6�   �� 5   
   -   5        $��btnDR��5   �   $��导入��6   $
��Left=�6   $��22��69   $��
275,20,0,0q�6E   $	��Top=�6Y   $��75��6q   6�   5      5      