   M S B A M L   `   `   `  ����G  CTasksAndritz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TasksAndritz.MVVM.ViewTasksAndritz.MVVM.View  5      I)clr-namespace:TasksAndritz.MVVM.ViewModelTasksAndritz.MVVM.ViewModel  5	      !    TasksAndritz.MVVM.View.Mocx   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TasksAndritz.MVVM.View     5      ?	viewModel)clr-namespace:TasksAndritz.MVVM.ViewModel     5	      $	��400��5      $	��500��6     � WindowStyle$
  None=�5
       � WindowStartupLocation$ CenterScreen=�5      
������  � 
ResizeMode$ NoResize=�5       � AllowsTransparency$
 True��5      .��5      �� ���#272537 �� CornerRadius$ 20��5      
���   �$��1q�5       �� Padding$ 10q�5      ._�5   
   �� .+�5      �� $��1��6   $��1��5      $��10q�5      ��5      �� *BarTop+�� 5      $��Stretch=�6   .+�5      �� $
��Mocx��6   $
��15,0q�5       �� Padding$ 0q�5      $��Center=�5      $	��Top=�5       
�������
������ $��25(�5#      �� 5%      $��Center=�6   $��10q�68    � 	Resources 5&       �� 
TargetType	 �� Property
 �� Value��%T   '��       �� 5'      " ��6    .�5(      �� 	 � ��$

 0,10q�67   5)      5*      .+�5+      �� .+�5,      �� $
��Code��6$   $
��15,5q�5-      $ 0q�5.      $
��Left=�5/      $��Center=�50      
�������
������ $��15(�53      �� 54      $ 10��6!   ���#353340$ 10q�56      $
��10,0q�57      ._�58      � .+�59   "   �� $��1��6,   �� 5:   "   -   5         ��Name$ clickTextBox��5>   !   $��Center=�5:   *   $��Stretch=�5;   !   $��5q�5<   !   
������ $��0q�5@   !   ���#CFCFCF��5=   !   �� *MocxObj.Cod+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5A   !   �� 5C   "    J� IsHitTestVisible$ False��6,   $��
ex: 123456��5D   (   $��Center=�5E   (   $
��Left=�5F   (   $��10,0,0,0q�5G   (   $��15(�5H   (   
�������$��1��5J   (   ��5L   &   �� 5M   *   " ��60    �� Triggers 5N   .   �� 5O   2    �� Binding 6>   �� *Text+ �� ElementName$ clickTextBox�� �� Value  6q   .a�5P   6   �� 	 � y�$
 Visible=�6S   5Q   3   .�5S   .   �� 	 � y�$
 Hidden=�6K   5T   +   5V   #   5W      5X      5Y      �� 5Z      .+�5[      �� $��Address (url)��6$   $
��15,5q�5\      $ 0q�5]      $
��Left=�5^      $��Center=�5_      
�������
������ $��15(�5b      �� 5c      $ 10��6!   ���#353340$ 10q�5e      $
��10,0q�5f      ._�5g      � .+�5h   "   �� $��1��6,   �� 5i   "   -   5        $ clickTextBox2��5m   !   $��Center=�5i   *   $��Stretch=�5j   !   $��5q�5k   !   
������ $��0q�5o   !   ���#CFCFCF��5l   !   �� *MocxObj.Address+$ TwoWay=�$ PropertyChanged=�5p   !   �� 5r   "   $ False��6,   $8��2ex: https://alm.andritz.com/jira/browse/MOCX-13227��5s   (   $��Center=�5t   (   $
��Left=�5u   (   $��10,0,0,0q�5v   (   $��15(�5w   (   
�������$��1��5y   (   ��5{   &   �� 5|   *   " ��60    5}   .   �� 5~   2    6>   �� *Text+$ clickTextBox2��  6r   .a�5   6   �� 	 � y�$
 Visible=�6S   5�   3   .�5�   .   �� 	 � y�$
 Hidden=�6K   5�   +   5�   #   5�      5�      5�      �� 5�      $��Bottom=�6!   .+�5�      �� -   5         ��Name$ borderButton��5�      $ 10q�5�   !   
������ $��0q�5�       � Cursor$
 Hand��5�      $ 10��5�       J� InputBindings 5�      d� 5�   "    d� MouseAction$ 	LeftClicke�6/    �� Command 5�   1   �� *SaveMocxCommand+._�5�      �� $
��Save��6(   $
��15,0q�5�       $ 0q�5�   !   $��Center=�5�   !   $��Center=�5�   !   
�������
������ $��15(�5�   !   5�      5�      5�      5�      5�      5�      5�      