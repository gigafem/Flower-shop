   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5	   	       WpfApp1.Window2   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	viewmodelclr-namespace:WpfApp1.ViewModel     5	   	     � Title$  	Home page��5   	   $	��500��6   $	��330��6(    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      %  WpfApp1.ViewModel.MenuViewModel  5   
   .��5      � .+�5   
   �� $��Images/MMenu.png��6   $
��Fill=�6*   $��	0,0,0,-50q�6:   �� 5   
   $��Log in as...��6   $��SimpleRonde)�6(   $��20(�5       J� RenderTransformOrigin$ 0.482,0.641&�6   $	��Top=�6B   $��Center=�6Z   $��Center=�6w   $��Center=�6�   $��	0,101,0,0q�6�   $	��330��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.025Q�6$   �� 5       �� Angle$ 0.416Q�6&   T� 5       T� Y$
 0.05Q�6)    T� X$ -0.058Q�62   5      5      �� 5   
   $��Welcome!��6   
���"�"�$��55(�6<   $
��Left=�5      $��1,29,0,0q�5      $	��Top=�5       $ 0.5,0.5&�5!      $��66��5"      $	��331��6   $��Italia Std Book)�6(   $��Center=�6E   z�5#      V� 5$      .~�5%      �� �� 5&      �� 5'      $ 0.295Q�6&   T� 5(      5)      5+      �� 5,   
   $��staff��6   $
��Left=�5-      $��87��5.      $	��Top=�5/      $��95��50      $��30(�6    � Cursor$
 Hand��51      $��Italia Std Book)�52      
�������$��
61,163,0,0q�53   %   ��54      �� *OpenStaffCommand+��56      �� 57      	 �� 
TargetType"	 ��6"   .R�58      �� ���	#FFFFB1B4
 J� Opacity$
 1Q�64    �� CornerRadius$ 30��59      
�������$��3q�5=      ._�5>      �� $��Center=�6+   $��Center=�5?      5@      5A      5C      �� 5D   
   -   5        $��GuestButton��5D      $��guest��6%   $
��Left=�5E      $��87��5F      $	��Top=�5G      $��98��5H      $��30(�5I      $��Italia Std Book)�5J      
�������
�������
���"�"�$��179,163,0,0q�5N      $
 Hand��5O      $ 
0.49,1.285&�5P   6   ��6   �� *OpenUserLogInCommand+��5Q      �� 5R      "	 ��6"   .R�5S      �� ���	#FFE2EFCE$ 30��5T      
���"�"�$��3q�5W      ._�5X      �� $��Center=�6+   $��Center=�5Y      5Z      5[      5]      5a      5b      