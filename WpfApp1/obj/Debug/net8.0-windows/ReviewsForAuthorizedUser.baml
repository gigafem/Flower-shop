   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5   	   &     WpfApp1.ReviewsForAuthorizedUser   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	viewmodelclr-namespace:WpfApp1.ViewModel     5   	     � Title$  Reviews��5	   	   $	��443��6   $	��443��6'    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      %  WpfApp1.ViewModel.MenuViewModel  5   
   .��5      � .+�5   
   � -   5         �Name$ WriteReviewPopup��5      ���	#AA000000$y�	Collapsed=�5       K� ZIndex$ 10��5      .+�5      �� 
������� �� CornerRadius$ 10��6(    �� Padding$ 20q�6:   $��Center=�5      $��Center=�6*   $	��400��5      $	��300��6   ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $��* �6(   �� 5      $
��Auto �6(   .+�5"      �� -   5        $	��✖��5"      $��30��5#      $��30��6    $��Right=�5$      $	��Top=�5%      
������ 
������ 
���  ��$
��Bold"�5)      5*      �� 5,      $��1��6!   $��0,10,0,0q�6.   .+�5-      �� -   5         ��Name$ NameBox��5-   "   $��My name��5.      $��0,0,0,10q�5/      $��30��50      �� 52      -   5        $ ReviewTextBox��52   "   	 �� AcceptsReturn$
	 True��53      
 �� TextWrapping$

 Wrap=�54      $	��120��55      $��Write a review here!...��56      58      �� 5;      -   5        $
��Send��5;      $��2��5<      $��Center=�5=      $��0,10,0,0q�5>      $
��10,5q�5?      
�������
�������$
��Bold"�5C      
������ $	��300��5E      $��40��5F      5G      5H      5I      �� 5K   
   $��Images/aboutUs.png��6   $
��fill=�6,   �� 5L   
   
�������$��Center=�6'   $	��316��6D   
������ $��Center=�6f   $	��364��6�   �� 5M   
   $��Images\mainGuest.png��6   $
��fill=�6.   $��
-27,0,-7,0q�6=   6S   �� 5N   
   $	��←��6   $
��Left=�5O      $	��191��5P      $	��Top=�5Q      $	��268��5R      $��35(�6    � Cursor$
 Hand��5S      $��Italia Std Book)�5T      
��� � �$��
10,344,0,0q�5U       J� RenderTransformOrigin$ 	0.46,0.34&�6W   ��6(   �� *GoBackMMForAuthUserCommand+z�5V      V� 5W      .~�5X      �� �� 5Y      �� 5Z       �� Angle$ 0Q�6&   T� 5[      5\      ��5^      �� 5_       �� 
TargetType" ��6"   .R�5`      �� 
�������$ 30��5a      
���"�"�$��2q�5c      $��0,0,213,142q�6   ._�5d      �� $��Center=�6+   $��Center=�5e      5f      5g      5i      �� 5j   
   $��Reviews��6   $��Center=�5k      $��50(�5l      $��86��6   $	��Top=�5m      $	��462��5n      $��Italia Std Book)�5o      $��0,42,0,0q�5p      
�������$��Center=�5q   (   $��Center=�6L   �� 5r   
   $\��V
   You can read the reviews about us and
leave yours by clicking on the button below!��6   $��Center=�5s      $��56��5t      $��0,97,0,0q�5u      $	��Top=�5v      $	��443��5w      $��Center=�5x      $��Center=�5y      $��12(�5z      $��Berlin Sans FB)�6"   
��� d �5{      �� 5|   
   -   5        $��Write��5|      $��Center=�5~   	   $��57��5   	   $	��Top=�5�   	   $	��182��5�   	   $��26(�5�   	   $��Italia Std Book)�5�   	   
��� ���$��	0,250,0,0q�5�   	   $
 Hand��5�   	   ��5�      �� 5�      " ��6"   .R�5�      �� $ 30��5�      
��� ���$��3q�5�      ���	#FFFFEFD8._�5�      �� $��Center=�6+   $��Center=�5�      5�      5�      5�      �� 5�   
   $
��Read��6   $��Center=�5�      $��57��5�      $	��Top=�5�      $	��182��5�      $��26(�5�      $��Italia Std Book)�5�      
��� ���$��	0,176,0,0q�5�      $
 Hand��5�      ��5�      �� 5�      " ��6"   .R�5�      �� $ 30��5�      
��� ���$��3q�5�      ���	#FFFFEFD8._�5�      �� $��Center=�6+   $��Center=�5�      5�      5�      5�      5�      5�      