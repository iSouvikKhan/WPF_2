   M S B A M L   `   `   `  ����G  COptimize.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Optimize.WPF.ComponentsOptimize.WPF.Components  5      +    %Optimize.WPF.Components.NavigationBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Optimize.WPF.Components     5      
���\\��  � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  '��       �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6$   5      5       5      P� 5       �@J�IsMouseOver . . �5      ��  � �� 5      �� 5      " ��6.   .R�5   "   �� #��z��6,   $��	Underline{�6M   5      5!      5#      5%      5&      .��5(      � $
��1000��6   $��20 10q�6    � ColumnDefinitions 5)   
   �� 5*      $��* �6   �� 5+      $
��auto �6   �� 5,      $
��auto �6   �� 5-      $
��auto �6   �� 5.      $
��auto �6   .+�51   
   �� $��0��6   $��14(�6!   
�������$��	Dashboard��6j   ��6B   �� *NavigateHomeCommand+6j   �� 53   
   $��1��6   $��30 0 0 0q�6!   $
��Home��6[   ��63   �� *NavigateHomeCommand+6[   �� 54   
   $��2��6   $��30 0 0 0q�6!   $��Disk Cleanup��6b   ��63   �� *NavigateDiskCleanupCommand+6b   �� 55   
   $��3��6   $��30 0 0 0q�6!   $��Startup Manager��6e   ��63   �� *NavigateStartupManagerCommand+6e   �� 56   
   $��4��6   $��30 0 0 0q�6!   $��System Information��6h   ��63   �� *" NavigateSystemInformationCommand+6h   57      58      