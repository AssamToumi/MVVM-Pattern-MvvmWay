   M S B A M L   `   `   `  ����I  EMvvm.Session01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Mvvm.Session01.ViewModelMvvm.Session01.ViewModel  5           Mvvm.Session01.View.People   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      =
ViewModels&clr-namespace:Mvvm.Session01.ViewModel     5        � DataContext  5      .   (Mvvm.Session01.ViewModel.PeopleViewModel  5   
   .��5      �  � RowDefinitions 5	   
   �� 5
      �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     CanUserAddRows .  ��6   �� *People+ �� SelectedItem 5      �� *SelectedPerson+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ 
First Name��6%    69   �� *	FirstName+  5      $ 	Last Name��6%    68   �� *
LastName+  5      $ 	Full Name��6%    68   �� *
FullName+5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� $	��New��6   ��6#   �� *
NewCommand+�� 5      $��Delete��6   ��6&   �� *DeleteCommand+5      5      5      