   M S B A M L   `   `   `  ����B  >Cashbox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CashboxCashbox  5   	       Cashbox.PrintCheck   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Cashbox     5   	   -   5          � Title$  
PrintCheck��5   	   $	��200��6   $	��353��6)      WindowStyle#��[  65   .��5	      � .+�5
   
   �� -   5         ��Name$ PABox��5
      $��
170,76,0,0q�6!   $	��150��65     TextBoxStyle#���  6A   6h   �� 5   
   -   5         ��Name$ PA��5      $��	30,79,0,0q�6!   $��Payment amount:��64     KassaTextBlock#��[ 6K   �� 5   
   -   5        $ Total��5      $��	30,30,0,0q�6$   $��Total:��67   #��[ 6E   �� 5   
   -   5        $ Count��5      $��	30,53,0,0q�6$   $"��Number of products in check:��67   #��[ 6[   �� 5   
   -   5        $ TotalResult��5      $��	0,35,69,0q�6*   $��0��6=   $��Right=�6G   #��[ 6c   �� 5   
   -   5        $ NumberResult��5      $��	0,53,69,0q�6+   $��0��6>   $��Right=�6G   #��[ 6c   �� 5   
   $��	0,35,27,0q�6   $	��USD��6'   $��Right=�63   #��[ 6O    J� RenderTransformOrigin$ 1.414,0.686&�6w   �� 5   
   -   5         ��Name$	 Pay��5      $	��Pay��6   $��Right=�6,   $��Bottom=�6H   $��
0,0,207,21q�6c     KassaButton#���  6w   6�   �� 5   
   -	   5        $ Print��5      $��Print check��6    $��Right=�66   $��Bottom=�6R   $��	0,0,37,21q�6m   #���  6�   5      5      