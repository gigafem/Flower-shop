   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5   	       WpfApp1.UserWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	viewmodelclr-namespace:WpfApp1.ViewModel     5   	     � Title$  Staff Control Panel��5	   	   $	��500��6%   $	��443��62    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      %  WpfApp1.ViewModel.MenuViewModel  5   
   .��5      � 
�������.+�5   
   �� $��Images/leavesFrame.png��6   $��UniformToFill=�60   $��-156,-107,82,112q�5       J� RenderTransformOrigin$ 0.5,0.5&�6*   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$	 -90Q�6&   T� 5      5      5      �� 5   
   $	��←��6   $
��Left=�5   	   $	��190��5   	   $	��Top=�5   	   $	��268��5    	   $��35(�6    � Cursor$
 Hand��5!   	   $��Italia Std Book)�5"   	   
��� � �$��
25,392,0,0q�5#      $ 	0.46,0.34&�5%   	   ��5$   	   �� *GoBackMMCommand+z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*      $ 0Q�6&   T� 5+      5,      ��5.      �� 5/       �� 
TargetType" ��6"   .R�50      �� 
������� �� CornerRadius$ 30��51      
���"�"�$��2q�53      $��0,0,213,142q�6)   ._�54      �� $��Center=�55      $��Center=�56      57      58      5:      �� 5<   
   $&�� Welcome to staff 
control panel!��6   
���"�"�$��35(�5>   	   $��Center=�5?   	   $��93��5@   	   $��0,18,0,0q�5A   	   $	��Top=�5B   	   $	��349��5C   	   $��Italia Std Book)�6   $��Center=�5D   	   $��Center=�5E   	   �� 5G   
   $��Orders��6   $��Center=�5H      $��71��5I      $	��Top=�5J      $	��170��5K      $��25(�6   $
 Hand��5L      $��Italia Std Book)�5M      $��	0,128,0,0q�5N      
���"�"���5P      �� *GoOrdersCommand+��5Q      �� 5R      " ��6"   .R�5S      �� ���	#FFE2EFCE J� Opacity$ 1Q�64   $ 30��5T      
���"�"�$��3q�5V      ._�5W      �� $��Center=�6+   $��Center=�5X      5Y      5Z      5\      �� 5^   
   $��Bouquets��6   $��Center=�5_   	   $��71��5`   	   $	��Top=�5a   	   $	��170��5b   	   $��25(�6   $
 Hand��5c   	   $��Italia Std Book)�5d   	   $��	0,204,0,0q�5e   	   
���"�"���5g   	   �� *GoBouquetsDGCommand+��5h      �� 5i      " ��6"   .R�5j      �� ���	#FFE2EFCE$ 1Q�64   $ 30��5k      
���"�"�$��3q�5m      ._�5n      �� $��Center=�5o      $��Center=�5p      5q      5r      5t      �� 5v   
   $��Compositions��6   $��Center=�5w      $��71��5x      $	��Top=�5y      $	��170��5z      $��25(�6   $
 Hand��5{      $��Italia Std Book)�5|      $��	0,280,0,0q�5}      
���"�"���5      �� *GoCompositionsDGCommand+��5�      �� 5�      " ��6"   .R�5�      �� ���	#FFE2EFCE$ 1Q�64   $ 30��5�      
���"�"�$��3q�5�      ._�5�      �� $��Center=�5�      $��Center=�5�      5�      5�      5�      �� 5�   
   $��Presents��6   $��Center=�5�      $��71��5�      $	��Top=�5�      $	��170��5�      $��25(�6   $
 Hand��5�      $��Italia Std Book)�5�      $��	0,356,0,0q�5�      
���"�"���5�      �� *GoPresentsDGCommand+��5�      �� 5�      " ��6"   .R�5�      �� ���	#FFE2EFCE$ 1Q�64   $ 30��5�      
���"�"�$��3q�5�      ._�5�      �� $��Center=�5�      $��Center=�5�      5�      5�      5�      5�      5�      