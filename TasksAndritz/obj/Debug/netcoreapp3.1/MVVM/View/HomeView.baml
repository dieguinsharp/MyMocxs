   M S B A M L   `   `   `  ����G  CTasksAndritz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TasksAndritz.MVVM.ViewTasksAndritz.MVVM.View  5      %    TasksAndritz.MVVM.View.HomeView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TasksAndritz.MVVM.View     5      .��5	      �� $��10q�6   .+�5
   
   �� ���#22202f  �� CornerRadius$  5��5      ._�5      � $��Stretch=�6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $	��Cod��6   $��0��5      $��Center=�5      $��Center=�5      
�������$��14(�5      $��20,10q�5      5      �� 5      $��Address��6   $��1��5      $��Center=�5      $��Center=�5      
�������$��14(�5      $��20,10q�5       �� 5!      $
��Date��6   $��2��5"      $��Center=�5#      $��Center=�5$      
�������$��14(�5&      $��20,10q�5'      5(      5)      �� 5+   
   -   5         ��Name$ lstMocx��5,      
������ 
������ $��Stretch=�5/      $��0q�50      ��5+      �� *Mocxs+��51      �� 52       �� 
TargetType" ��6   .�53      ��  �� Property � �� �� Value$ Stretch=�6C   �� 54       � ��$ 0��62   55      ��57      �� 58      .R�59      �� $  5��6    J� InputBindings 5;      d� 5<       d� MouseAction$ 	LeftClicke�6+    �� Command 5=   +   �� *DataContext.OpenMocxCommand+	 �� Source	 %  System.Windows.Markup.Reference  *	lstMocx+
 �� CommandParameter
 5>   +   �� *.+��5A      �� 5B       �� 
StartPoint$	 0,0&�62    �� EndPoint$	 1,2&�6C   .��5C   "   �  � Color$ #22202f��6/    � Offset$	 0.0Q�6?   � 5D   "   $ #272537��6/   $	 0.5Q�6?   � 5E   "   $ #333835��6/   $	 1.0Q�6?   5F      ._�5H      � $��Stretch=�6    5I      �� 5J   "   $��* �63   �� 5K   "   $��* �63   �� 5L   "   $��* �63   �� 5M   "   $
��Auto �63    � 	Resources 5P      ��%R   '��       �� 5Q   "   " ��6(   .�5R   &   ��  � ��$ 10q�6?   5S   #   5T      .+�5V      �� $��0��5W   (   $��Center=�5X   (   $��Center=�5Y   )   
�������$��14(�5[   )   ��5V   (   �� *Cod+ �� StringFormat$ MOCX-{0}��5\      �� 5]      $��1��5^   (   $��Center=�5_   (   $��Center=�5`   )   
�������$��14(�5b   )   ��5]   (   �� *	Address+5b   )   �� 5c      $��2��5d   (   $��Center=�5e   (   $��Center=�5f   )   
�������$��14(�5h   )   ��5c   (   �� *Date+$ {0:dd/MM/yyyy}��5h   )   �� 5j      $	  100��6%    �� Padding$ 0q�5k   %   $��25��5l   %   $��25��5m   %   $��3��5n   %    � Cursor$
 Hand��5o   %   
���  ��$��5q�5q   %   ._�5s   "   �� $��X��6,   $��0q�5t   %   $
��Bold"�5u   %   $��Center=�5v   %   $��Center=�5w   %   
�������
������ $��10(�5z   %    5|   "   d� 5}   &   $ 	LeftClicke�63    5~   +   �� *DataContext.DeleteMocxCommand+	   *	lstMocx+
 5   +   �� *.+5�      5�      5�      5�      5�      5�      5�      