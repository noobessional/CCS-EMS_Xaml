   M S B A M L   `   `   `  ����B  >CCS-EMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CCS_EMSCCS_EMS  5   	       CCS_EMS.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CCS_EMS     5   	     � Title$  
MainWindow��5   	   $	��480��6   $	��720��6)    � WindowStyle$
 None=�65    � WindowStartupLocation$ CenterScreen=�6H   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   �� ._�5      �  � ColumnDefinitions 5      �� 5      -   5         ��Name$ LOGIN_PANEL��5   '   $��4* �6<   �� 5      -   5        $ WELCOME_PANEL��5   '   $��5* �6>   .+�5      �� $��0��6   ���#1C1D21 �� CornerRadius$ 	10 0 0 10��6>    �� Padding$ 60 20q�6W   ._�5      � $��Stretch=�6   $��Stretch=�69   .+�5      �� .+�5      ��    CCS_LOGO#��[  6$   $"��/IMAGES/Default/ccs_logo.png��6F   � 5      $��0 20 0 0q�6#   �� 5      $��Login��6(   
�������$��25(�6H   $
��Bold"�6V   � 5      $��0 5 0 0q�6#   �� 5      $ ��Enter your account details��6(   
�������$��8(�6a   � 5      $��0 20 0 0q�6#   �� 5      -   5        	 ��Name$	 UsernameBox��5   &   $��Username��6;     TEXTBOX#��[ 6K   6�   � 5      $��0 10 0 0q�6#   .+�5   "   G� -   5        
 G�Name$
 PasswordBox��5   .   #��[ 6C   6�   �� 5   "   -   5         ��Name$ PasswordPlaceholder��5   ,   $��Password��6I     PASSWORD_PLACEHOLDER#��[ 6Y   $y�Visible=�6�    J� IsHitTestVisible .  6�   5      � 5      $��0 20 0 0q�6#   �� 5      -   5         ��Name$ LOGIN_BUTTON��5   %   $��Login��6;     LOGIN_BUTTON#��[ 6K   6�   5       5!      5"      �� 5#      $��1��6   ���#925FE2$ 	0 10 10 0��6>   ._�5$      � .+�5%      �� $)��#/IMAGES/Default/backgroundlogin.png��6    $��UniformToFill=�6M   �� 5&      $��40 60q�6%   .+�5'      �� $��
Welcome to��6(   
�������$
��Bold"�6M   $��30(�6_   $��0 -10q�6m   �� 5(      $��	CCS Event��6(   
�������$��Light"�6L   $��30(�6_   �� 5)      $��Management System��6(   
�������$��Light"�6T   $��30(�6g   $��	0 -10 0 0q�6u   �� 5*      $"��Login to access your account��6(   
�������$��Light"�6_   5+      5,      5-      5.      5/      50      51      