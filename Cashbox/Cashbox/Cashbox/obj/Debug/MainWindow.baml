   M S B A M L   `   `   `  ����B  >Cashbox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CashboxCashbox  5   	       Cashbox.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Cashbox     5   	     � Title$  Login��5   	   $	��210��6   $	��300��6$      WindowStyle#��[  60   .��5
      � .+�5   
   �� -   5         ��Name$ 	LoginText��5      $��	29,35,0,0q�6(   $��Login��6;     KassaTextBlock#��[ 6H   �� 5   
   -   5        $ PasswordText��5      $��	29,71,0,0q�6*   $��Password��6=   #��[ 6M   �� 5   
   -   5         ��Name$ LoginBox��5      $��
103,30,0,0q�6$   $	��162��68     TextBoxStyle#���  6D   G� 5   
   -   5         G�Name$ PasswordBox��5      $��
103,66,0,0q�6+   $	��162��6?   #���  6K   �� 5   
   -   5         ��Name$ OkButton��5      $��OK��6#   $��Center=�60   $��Bottom=�6M   $��29,0,165,21q�6h     KassaButton#���  6}    J� RenderTransformOrigin$ 
-0.27,0.36&�6�   �� 5   
   -   5        $ LoginWarning��5      $��
119,98,0,0q�6+   $ ��Invalid login or password!��6?     KassaWarningTextBlock#��[ 6a   �� 5   
   -   5        $ CloseButton��5      $��Close��6&   $��Center=�66   $��Bottom=�6S   $��165,0,29,21q�6n   #���  6�   $ 
-0.27,0.36&�6�   5      5      