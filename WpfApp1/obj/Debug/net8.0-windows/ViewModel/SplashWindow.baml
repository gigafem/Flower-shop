   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5   	   $    WpfApp1.ViewModel.SplashWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfApp1.ViewModel     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc-wgif"http://wpfanimatedgif.codeplex.com  5	   	     � Title$  SplashWindow��5   	   $	��440��6   $	��440��6+    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��5   	   
������  � ShowInTaskbar$ False��5   	    � Topmost$
 True��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� 
������� �� CornerRadius$ 10��6$    �� Padding$ 20q�66   ._�5      �� $��Center=�6   $��Center=�66   .+�5      �� -   5        	 ��Name$	 
LoadingGIF��5      $	��200��6,   $	��200��68   $��Uniform=�6E   �� 5      -   5        
 ��Name$
 
StatusText��5      $��
Loading...��60   $��0,20,0,0q�6C   $��18(�6U   $��Center=�6c   $��SimpleRonde)�6�   5      5      5      5      