   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5   	       WpfApp1.Window3   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	viewmodelclr-namespace:WpfApp1.ViewModel     5   	     � Title$  Staff authorization page��5	   	   $	��480��6+   $	��462��68    � WindowStartupLocation$ CenterScreen=�5
   
    � DataContext 5      %  WpfApp1.ViewModel.MenuViewModel  5   
   .��5      � .+�5   
   �� $��Images/authorization.png��6   $
��none=�62   �� 5   
   
�������$��Center=�6'   $	��261��6D   
������ $	��Top=�6f   $	��327��6~   $��0,45,0,0q�6�   �� 5   
   $	��←��6   $
��Left=�5   	   $	��192��5   	   $	��Top=�5   	   $	��268��5   	   $��35(�6    � Cursor$
 Hand��5   	   $��Italia Std Book)�5   	   
��� � �$��
10,348,0,0q�5       J� RenderTransformOrigin$ 	0.46,0.34&�6T   ��60   �� *GoBackMMCommand+z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0Q�6&   T� 5       5!      ��5#      �� 5$       �� 
TargetType" ��6"   .R�5%      �� 
������� �� CornerRadius$ 30��5&      
���"�"�$��2q�5(      $��0,0,213,142q�6%   ._�5)      �� $��Center=�6+   $��Center=�5*      5+      5,      5.      �� 5/   
   $��Who are you?��6   
�������$��40(�6?   $��Center=�50      $��0,53,0,0q�51      $	��Top=�52      $ 0.5,0.5&�53      $	��141��54      $	��441��6   $��Italia Std Book)�6%   $��Center=�6B   z�55      V� 56      .~�57      �� �� 58      �� 59      $ 0.295Q�6&   T� 5:      5;      5=      �� 5>   
   $��Login:��6   $��SimpleRonde)�6"   $��136,104,0,0q�6;   $��20(�6P   $ 0.479,0.869&�6^   $	��Top=�6�   $
��Left=�6�   $��61��6�   $	��177��6�   z�5?      V� 5@      .~�5A      �� �� 5B       �� AngleY$
 0.01Q�6$   �� 5C      $ 0.416Q�6&   T� 5D      	 T� Y$	 0.023Q�6)   
 T� X$
 -0.215Q�63   5E      5G      �� 5H   
   $��	Password:��6   $��SimpleRonde)�6%   $��	0,195,0,0q�6>   $��20(�6Q   $ 0.5,0.5&�6_   $	��Top=�6   $��Center=�6�   $��79��6�   $	��163��6�   z�5I      V� 5J      .~�5K      �� �� 5L      $
 0.01Q�6$   �� 5M      $ 0.416Q�6&   T� 5N      $	 0.051Q�6)   5O      5Q      �� 5R   
   -   5        $��log in��5R      $��Center=�5S      $��38��5T      $	��Top=�5U      $	��112��5V      $��30(�6   $
 Hand��5W      $��Italia Std Book)�5X      
�������$��	0,329,0,0q�5Y   %   ��5\      �� 5]      " ��6"   .R�5^      �� ���	#FFFFB1B4 J� Opacity$ 1Q�64   $ 30��5_      
�������$��3q�5c      $��
0,0,-8,-12q�6%   ._�5d      �� $��Center=�6+   $��Center=�5e      5f      5g      5i      �� 5k   
   -   5         ��Name$ UsernameBox��5k      $��Center=�5l   
    �� TextWrapping$
 Wrap=�5m   
   $	��Top=�5n   
   $	��184��5o   
   $��28��6   $��	0,164,0,0q�5p   
   G� 5r   
   -   5         G�Name$ PasswordBox��5r      $��Center=�5s      $	��Top=�5t      $	��184��5u      $��28��6   $��	0,246,0,0q�5v      �� 5x   
   -   5         ��Name$ 
ResultText��5x      $��Center=�5y      $	��Top=�5z      $��	0,275,0,0q�5{      
���  ��$��14(�5}       �� TextAlignment$ Center=�5~      5�      5�      