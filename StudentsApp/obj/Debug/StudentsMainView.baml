   M S B A M L   `   `   `  ����F  BStudentsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:StudentsApp.ControlsStudentsApp.Controls  5      ?$clr-namespace:StudentsApp.ConvertersStudentsApp.Converters  5      )clr-namespace:StudentsAppStudentsApp  5      ?$clr-namespace:StudentsApp.ViewModelsStudentsApp.ViewModels  5
          StudentsApp.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      7controls"clr-namespace:StudentsApp.Controls     5      ;
converters$clr-namespace:StudentsApp.Converters     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:StudentsApp     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5	      5user$clr-namespace:StudentsApp.ViewModels     5
        � Title$  StudentsApp��5      $	��600��5      $	��360��5       � DataContext 5      2   ,StudentsApp.ViewModels.StudentsMainViewModel  5   
    � 	Resources 5      D   >StudentsApp.Converters.SelectedStudentEnableEditPanelConverter +  'SelectedStudentEnableEditPanelConverter�� 5   
   %   &	          5      6A   5      .��5      � $��Bottom=�6    � ColumnDefinitions 5   
   �� 5      $
��289* �6   �� 5      $
��302* �6   .+�5   
   �� $��1��6   $��4.6,5,4.6,0.2q�6%   .+�5      �� -   5         ��Name$ readStudentBut��5      $	��237��5      $��30,2,0,0q�5       $
��Left=�5!      $	��Top=�5"      $��View student��5$      ��5#      �� *ViewStudentsCommand+5$      �� 5%      -   5        $ addStudentBut��5&      $	��237��5'      $��	30,12,0,0q�5(      $
��Left=�5)      $	��Top=�5*      $��Add student��5,      ��5+      �� *AddStudentCommand+5,      �� 5-      -   5        $ delStudentBut��5.      $	��237��5/      $��	30,12,0,0q�50      $
��Left=�51      $	��Top=�52      $��Delete student��55      ��53      �� *DeleteStudentCommand+��54      �� *SelectedStudent+55      �� 56      -   5        $ updStudentBut��57      $	��237��58      $��20��59      $��	30,12,0,0q�5:      $
��Left=�5;      $	��Top=�5<      $��Update student��5?      ��5=      �� *UpdateStudentCommand+��5>      �� *SelectedStudent+ �� UpdateSourceTrigger$ PropertyChanged=�5?      �� 5@      $	��194��5A      $��	5,5,5.4,5q�5B       5C      �� *SelectedStudent+ �� Mode$ TwoWay=�{�5D      �� *SelectedItem+ �� 	Converter# [   �� ElementName$ studentsListView��.+�5E      �� $��SELECTED STUDENT:��6   '   !StudentsApp.Controls.EditProperty  5Q      	   
HeaderText$	 	Last Name��6(   
   Value
 6?   �� *
LastName+$ TwoWay=�$ PropertyChanged=�  5R      $��	5,5,4.8,5q�5S      $	 
First Name��5T      
 5U      �� *	FirstName+$ TwoWay=�$ PropertyChanged=�  5V      $		 Age��6(   
 69   �� *Age+$ TwoWay=�$ PropertyChanged=�  5W      $	 Gender��6(   
 6<   �� *Gender+$ TwoWay=�$ PropertyChanged=�5X      5Y      �� 5Z   
   -   5         ��Name$ studentsListView��5[      $
��Auto��5\      $��0,0,0.4,0.4q�5]      $��Stretch=�5^      $��Stretch=�5_      ��5`      �� *
Students+ �� SelectedItem 5a      �� *SelectedStudent+ �� View 5b      �� 5c      .P�5d      ��  �� Width$
 Auto��5e      $��Id��5g       �� DisplayMemberBinding 5f      �� *Id+5g      �� 5h      $
 Auto��6%   $��Last Name/First Name��62    �� CellTemplate 5i      �� 5j      .R�5k   "   �� ��5l   &   `� 5m   *    �� StringFormat$ {1} {0}��67   .1�5n   .   ��  �� Path$ 	FirstName�66   �� 5o   .   $ LastName�66   5p   +   5r   #   5s      5u      �� 5v      $
 Auto��5w      $	��Age��5y       5x      �� *Age+$ {0} (лет)��5y      �� 5z      $
 Auto��5{      $��Gender��5}       5|      �� *Gender+5}      5~      5�      5�      5�      