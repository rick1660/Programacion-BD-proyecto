   M S B A M L   `   `   `  ����W  SProyecto Final concesionaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Proyecto_Final_concesionariaProyecto_Final_concesionaria  5   	   -    'Proyecto_Final_concesionaria.MainWindow   5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Proyecto_Final_concesionaria     5   	     � Title$  
MainWindow��5
      $	��700��6   $	��700��6%   $	��900��65   $	��800��6A    � WindowStartupLocation$ CenterScreen=�6P    � WindowState$ Normal=�6u   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.8* �6   �� 5      $��1* �6    .+�5   
   � -   5         �Name$
 Left��5      ���#3F819D$��0��64   .+�5      �� $��Consesionaria��6   $��Center=�6,   $��Center=�6I   $��Arial Black)�6d   $��36(�6}   $��
ExtraBlack"�6�   
�������6�   5      � 5   
   -   5        $ Right��5      ���#3F819D$��1��65    � RowDefinitions 5      �� 5      $
��0.3* �6!   �� 5       $��1* �6!   �� 5!      $
��0.3* �6!   .+�5$      � ���#EDEEEE$��1��6(   .+�5&      � $��Center=�6   $��Center=�64   $	��400��6P   $	��350��6\    5'      �� 5(      $
��0.4* �6(   �� 5)      $
��0.3* �6(   �� 5*      $
��0.3* �6(   �� 5+      $
��0.3* �6(   �� 5,      $
��0.3* �6(   �� 5-      $
��0.4* �6(   .+�5/      �� $��0��6   $��Iniciar de sesion��6)   $��Center=�6E   $��Bottom=�6c   $��22(�6~   $
��Bold"�6�   $��Arial Black)�6�   �� 50      $��1��6   $��Correo��6)   $��Center=�6:   $��Center=�6X   $��20(�6s   $
��Bold"�6�   $��Arial Black)�6�   �� 51      -   5         ��Name$ 	txtCorreo��51      $��Center=�61   $��35��6N   $��2��6Z   $	��Top=�6g   $	��250��6    �� TextAlignment$ Center=�6�   $��19(�6�   �� 52      $��3��6   $��Contraseña��6)   $��Center=�6>   $��Center=�6\   $��20(�6w   $
��Bold"�6�   $��Arial Black)�6�   �� 53      -   5        $ txtPassword��53      $��Center=�63   $��35��6P   $��4��6\   $	��Top=�6i   $	��250��6�   $ Center=�6�   $��19(�6�   �� 54      $��5��6   $"��Haz Olvidado tu contraseña?��6)   $��center=�6O   $	��Top=�6n   $
��Bold"�6�   $��Arial Black)�6�   �� 55      -   5         ��Name$ BtnIngresar��55      $��5��62   $��Ingresar��6?   $��Center=�6R   $��Bottom=�6p   $	��150��6�   $��30��6�   $��15(�6�   $��Arial Black)�6�   ���#21414C
�������6�   59      5;      5=      5@      5A      