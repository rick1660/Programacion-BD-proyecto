   M S B A M L   `   `   `  ����W  SProyecto Final concesionaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Proyecto_Final_concesionariaProyecto_Final_concesionaria  5   	   ,    &Proyecto_Final_concesionaria.Principal   5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Proyecto_Final_concesionaria     5   	   $	��600��5
   	   $
��1080��6     � 
ResizeMode$  NoResize=�6$    � WindowStartupLocation$ CenterScreen=�6:    � WindowStyle$
 None=�6_   
������� � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 BtnOpen��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 BtnClose��66   .[�5       �� #��[ 6   5!      .��5$      � 
�������.+�5%   
   � $��60��6   $	��Top=�6   ���#3F819D.+�5&      �� $��Gestor de gastos��6   $��Center=�60   $��Center=�6M   $��22(�6h   �� 5'      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5(      �� $��Ricardo Javier��6   $��Center=�62   $��18(�6M   '  !MaterialDesignThemes.Wpf.PopupBox  5)      $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen .     PopupContent. 5*      �� $	��150��6!   .+�5+      �� $��Cuenta��6!   �� 5,      $��Configuraciones��6!   �� 5-      �� 5.      -   5         ��Name$ BtmPopupSalir��5.   !   $��Salir��68   6H   5/      50      51      52      � 54   
   -   5         �Name$ GridMenu��54      $��60��6!   $
��Left=�6,   ���#9ECBDB.+�55      �� .+�56      � $	��150��6   ���#EDEEEE.+�57      �� -   5        $ BtnClose��57      $��70��60   $��70��6;   $	��Top=�6t   $��Right=�6�   $y�	Collapsed=�6�   ��6G   Z� ��6]   Z� .��58      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   
���   �$��30��6V   $��30��6a   59      �� 5:      -   5        $ BtnOpen��5:      $��70��6.   $	��Top=�6g   $��Right=�6   ��6:   Z� ��6P   Z� .��5;        $
 Menu=�62   
���   �$��30��6Q   $��30��6\   5<      5=      �� 5>      $��Disabled=�6   ���#3F819D.@�5B      �� $��60��6#   .��5C      �� -   5        $ BtnOne��5C   %   $��Center=�6d   $��Center=�6   $��60��6�   $��60��6�   ��67   Z� ��6M   Z� .��5D   "   �� $ 
Horizontal=�6-   .+�5E   &     $ ViewDashboard=�6>   $��30��6U   $��30��6`   $��Center=�6l   �� 5F   &   $
��Home��60   $��Center=�6<   $��20 10q�6W   5G   #   5H      5I      �� 5L      $��60��6#   .��5M      �� -   5        $ BtnTwo��5M   !   $��Center=�6`   $��Center=�6{   $��60��6�   $��60��6�   ��63   Z� ��6I   Z� .��5N      �� $ 
Horizontal=�6)   .+�5O   "     $ ViewDashboard=�6:   $��30��6Q   $��30��6\   $��Center=�6h   �� 5P   "   $
��Home��6,   $��Center=�68   $��20 10q�6S   5Q      5R      5S      �� 5U      $��60��6#   .��5V      �� -   5        $ BtnThree��5V   !   $��Center=�6b   $��Center=�6}   $��60��6�   $��60��6�   ��65   Z� ��6K   Z� .��5W      �� $ 
Horizontal=�6)   .+�5X   "     $ ViewDashboard=�6:   $��30��6Q   $��30��6\   $��Center=�6h   �� 5Y   "   $
��Home��6,   $��Center=�68   $��20 10q�6S   5Z      5[      5\      �� 5^      $��60��6#   .��5_      �� -   5        $ BtnFourd��5_   !   $��Center=�6b   $��Center=�6}   $��60��6�   $��60��6�   ��65   Z� ��6K   Z� .��5`      �� $ 
Horizontal=�6)   .+�5a   "     $ ViewDashboard=�6:   $��30��6Q   $��30��6\   $��Center=�6h   �� 5b   "   $
��Home��6,   $��Center=�68   $��20 10q�6S   5c      5d      5e      �� 5g      $��60��6#   .��5h      �� -	   5        $ BtnFive��5h   !   $��Center=�6a   $��Center=�6|   $��60��6�   $��60��6�   ��64   Z� ��6J   Z� .��5i      �� $ 
Horizontal=�6)   .+�5j   "     $ ViewDashboard=�6:   $��30��6Q   $��30��6\   $��Center=�6h   �� 5k   "   $
��Home��6,   $��Center=�68   $��20 10q�6S   5l      5m      5n      �� 5p      $��60��6#   .��5q      �� -
   5        $ BtnSix��5q   !   $��Center=�6`   $��Center=�6{   $��60��6�   $��60��6�   ��63   Z� ��6I   Z� .��5r      �� $ 
Horizontal=�6)   .+�5s   "     $ ViewDashboard=�6:   $��30��6Q   $��30��6\   $��Center=�6h   �� 5t   "   $
��Home��6,   $��Center=�68   $��20 10q�6S   5u      5v      5w      �� 5y      $��60��6#   .��5z      �� -   5        $	 Btn��5z   !   $��Center=�6]   $��Center=�6x   $��60��6�   $��60��6�   ��60   Z� ��6F   Z� .��5{      �� $ 
Horizontal=�6)   .+�5|   "     $ ViewDashboard=�6:   $��30��6Q   $��30��6\   $��Center=�6h   �� 5}   "   $
��Home��6,   $��Center=�68   $��20 10q�6S   5~      5      5�      5�      5�      5�      5�      5�      