   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5   	        WpfApp1.CatalogForAuthUser   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	viewmodelclr-namespace:WpfApp1.ViewModel     5   	     � Title$  Catalog��5	   	   $	��360��6   $	��640��6'    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      %  WpfApp1.ViewModel.MenuViewModel  5   
   .��5      � .+�5   
   �� $��Images/catalog1.png��6   $
��Fill=�6-   �� 5   
   $	��←��6   $
��Left=�5      $	��192��5      $	��Top=�5      $	��268��5      $��35(�6    � Cursor$
 Hand��5      $��Italia Std Book)�5      
��� � �$��
10,256,0,0q�5       J� RenderTransformOrigin$ 	0.46,0.34&�6W   ��6(   �� *GoBackMMForAuthUserCommand+z�5      V� 5      .~�5      �� �� 5      �� 5        �� Angle$ 0Q�6&   T� 5!      5"      ��5$      �� 5%       �� 
TargetType" ��6"   .R�5&      �� 
������� �� CornerRadius$ 30��5'      
���"�"�$��2q�5)      $��0,0,213,142q�6   ._�5*      �� $��Center=�6+   $��Center=�5+      5,      5-      5/      �� 51   
   $��bouquets��6   $��Center=�53      $��71��54      $	��Top=�55      $	��156��56      $��25(�6   $
 Hand��57      $��Italia Std Book)�58      $��0,85,0,0q�59      
���������5;      �� * OpenBouquetsForAuthUserCommand+��5<      �� 5=      " ��6"   .R�5>      �� ���	#FFFFB1B4 J� Opacity$ 1Q�64   $ 30��5?      
�������$��3q�5C      ._�5D      �� $��Center=�6+   $��Center=�5E      5F      5G      5I      �� 5J   
   $��compositions��6   $��Center=�5K      $��71��5L      $	��Top=�5M      $	��156��5N      $��25(�6   $
 Hand��5O      $��Italia Std Book)�5P      
�������$��	0,161,0,0q�5R      ��5S      �� *$"OpenCompositionsForAuthUserCommand+��5T      �� 5U      " ��6"   .R�5V      �� ���	#FFFFB1B4$ 1Q�64   $ 30��5W   	   
�������$��3q�5[   	   ._�5\      �� $��Center=�6+   $��Center=�5]      5^      5_      5a      �� 5b   
   $��presents��6   $��Center=�5c      $��71��5d      $	��Top=�5e      $	��156��5f      $��25(�6   $
 Hand��5g      $��Italia Std Book)�5h      $��	0,237,0,0q�5i      
���������5k      �� * OpenPresentsForAuthUserCommand+��5l      �� 5m      " ��6"   .R�5n      �� ���	#FFFFB1B4$ 1Q�64   $ 30��5o      
�������$��3q�5s      ._�5t      �� $��Center=�6+   $��Center=�5u      5v      5w      5y      �� 5z   
   $��Catalog��6   
�������$��55(�5{      $��Center=�6   $��85��5|      $	��Top=�6   $	��364��64   $��Italia Std Book)�5}      $��Center=�6-   5      5�      