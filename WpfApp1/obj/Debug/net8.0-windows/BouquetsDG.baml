   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5	   	       WpfApp1.BouquetsDG   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	viewmodelclr-namespace:WpfApp1.ViewModel     5	   	     � Title$  
BouquetsDG��5   	   $	��443��6   $	��380��6)    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      %  WpfApp1.ViewModel.MenuViewModel  5   
   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ BouquetsDataGrid��5         AutoGenerateColumns$
 True��6-   $��10,10,10,150q�6H   �� 5   
   -   5        
������$��Export to Excel��5   )   $��Center=�6C   $��35��6`   $��	0,282,0,0q�5   	   $	��Top=�6   $	��200��64   $��20(�6@   $��Italia Std Book)�5   	   
���"�"�5   	   �� 5   
   -   5        
����ح�$��Export to Word��5   (   $��Center=�6A   $��35��6^   $��	0,322,0,0q�5   	   $	��Top=�6   $	��200��64   $��20(�6@   $��Italia Std Book)�5   	   
����=H�5   	   �� 5   
   -   5        
�������$��Export to .txt��5   (   $��Center=�6A   $��35��6^   $��	0,362,0,0q�5   	   $	��Top=�6   $	��200��64   $��20(�6@   $��Italia Std Book)�5   	   
���iii�5   	   5      5      