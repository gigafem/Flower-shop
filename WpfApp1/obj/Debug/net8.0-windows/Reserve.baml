   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5   	       WpfApp1.Reserve   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	viewmodelclr-namespace:WpfApp1.ViewModel     5   	     � Title$  Contacts��5	   	   $	��360��6   $	��640��6'    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      %  WpfApp1.ViewModel.MenuViewModel  5   
    � 	Resources 5         FlatImageButton �� 
TargetType �� Property �� Value �� 
TargetType  SpinnerAnimation g� RepeatBehavior	 �� 
TargetName
 �� TargetProperty W� From	 W� To g� Duration  CartOpenStoryboard g� DecelerationRatio  FadeOutStoryboard g� FillBehavior��%{  &	        &	     &	 �    &	 �    �� 5   
   " ��6(   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 ���� 6,   �� 5       � |�$ False��6*   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��Center=�6+   $��Center=�6H   5      5      5      �� 5   
   $ Forever��6.   .��5      W� $	 SpinnerTransform��5    	   $
 Angle�5!   	    05"   	    106   $ 0:0:1D�5#   	   5$      �� 5%   
   .��5&      W� $	 	CartPanel��6   $
 Opacity�5'       05(       16   $ 0:0:0.3D�5)      W� 5*      $	 	CartPanel��6   $,
 &RenderTransform.(TranslateTransform.X)�5+       505,       06    $ 0:0:0.3D�5-      $	 0.9Q�5.      5/      �� 50   
   .��51      W� $
 Opacity�52       053      $ 0:0:1D�54      $
 Stop=�55      56      58      .��5:      � .+�5;   
   � -   5        $��goInstagram��5;      ���	#AA000000$y�	Collapsed=�69    K� ZIndex$ 10��6P   .+�5<      �� $��Center=�6   $��Center=�66   .+�5=      A� $��60��6   $��60��6%   
�������$��6��6@    J� RenderTransformOrigin$ 0.5,0.5&�5>   
   z�5?      �� 5@      -   5        SpinnerTransform�� �� Angle$ 0Q�5@   D   5B      �� 5C      $#��redirecting to the website...��6   
�������$��20(�6T   $��Center=�5D      $��10q�6)   $��SimpleRonde)�65   5E      5F      �� 5G   
   $��Images/contacts.png��6   $
��Fill=�6-   $��1,0,0,-4q�6<   $ 0.5,0.5&�6N   z�5H      V� 5I      .~�5J      ��  �� ScaleX$ -1Q�6%   �� 5K      �� 5L      T� 5M      5N      5P      �� 5Q   
   $��Contacts��6   $
��Left=�5R      $	��Top=�5S      $��55(�5T      $��Italia Std Book)�5U      
���"�"�$	��116��5W      $	��354��5X      $��
146,10,0,0q�6   $��Center=�60   $��Center=�6T   �� 5Y   
   $	��←��6   $
��Left=�5Z      $	��192��5[      $	��Top=�5\      $	��268��5]      $��35(�6    � Cursor$
 Hand��5^      $��Italia Std Book)�5_      
��� � �$��
10,256,0,0q�5`      $ 	0.46,0.34&�6J   ��6(   �� *GoBackCommand+z�5a      V� 5b      .~�5c      �� �� 5d      �� 5e      $ 0Q�6&   T� 5f      5g      ��5i      �� 5j      " ��6"   .R�5k      �� 
������� �� CornerRadius$ 30��5l      
���"�"�$��2q�5n      $��0,0,213,142q�6   ._�5o      �� $��Center=�6+   $��Center=�5p      5q      5r      5t      �� 5v   
   $����Address: 
Moscow, Tverskaya St., 18, building 1 
Pushkinskaya / Tverskaya metro station

Phone:
+7 (495) 123-45-67

📧 Email:
info@flowers-tverskaya.ru

Opening hours:
Mon–Sun: 9:00 – 21:00

📱 Instagram:
@kostopraww��6   $
��Left=�6?  $	��229��6Z  $��
219,79,0,0q�5w      $	��Top=�6$   $	��245��6<   $��Center=�6H   $��Center=�6l   $��10(�5x      $��Berlin Sans FB)�6   
��� d �6;   �� 5y   
   -   5        $��← go��5y      $
��Left=�5z      $	��148��5{      $	��Top=�5|      $	��261��5}      $��9(�6   $
 Hand��5~      $��Italia Std Book)�5      
��� � �$��321,252,0,0q�5�       $ 	0.46,0.34&�65   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      $ 0Q�6&   T� 5�      5�      ��5�      �� 5�      " ��6"   .R�5�      �� 
�������$ 10��5�      
���"�"�$��2q�5�      $��0,0,218,125q�6%   $ 0.521,-0.06&�6:   ._�5�      �� $��Center=�6+   $��Center=�5�      5�      5�      5�      5�      5�      