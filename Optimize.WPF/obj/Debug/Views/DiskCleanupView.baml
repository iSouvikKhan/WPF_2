   M S B A M L   `   `   `  ����G  COptimize.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Optimize.WPF.ViewsOptimize.WPF.Views  5      A%clr-namespace:Optimize.WPF.ComponentsOptimize.WPF.Components  5      (    "Optimize.WPF.Views.DiskCleanupView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Optimize.WPF.Views     5      <
components%clr-namespace:Optimize.WPF.Components     5      .��5      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   +   %Optimize.WPF.Components.NavigationBar  $��0��6#    � DataContext 60   �� *NavigationBarViewModel+�� 5   
   $��1��6   $��28(�6!   $��Disk Cleanup��6/   $��
10 10 0 10q�6C   � 5   
   $��2��6   $
��1000��6   $��20q�6,   $��Center=�68   $��Center=�6U     5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��1��6   .+�5      �� -   5         ��Name$ TempFilesCheckBox��5   I   $
��0 10q�6   $��Clean Temporary Files��6)   6I   �� 5      -   5        $ RecycleBinCheckBox��5   E   $
��0 10q�6   $��Clean Recycle Bin��6)   6E   �� 5       -   5        $
��0 10q�5       $��Start Cleanup��6'   6?   � 5!      -   5         �Name$ ProgressBar��5!   ,   $
��0 10q�6   $��20��6A    � Minimum$ 0Q�6M    � Maximum$	 100Q�6Y   5"      5#      5%      5&      