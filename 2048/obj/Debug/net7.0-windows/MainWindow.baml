   M S B A M L   `   `   `  ����?  ;2048, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_2048_2048  5   	       _2048.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:_2048     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��400��6,   $	��500��6;   $	��400��6H    � 	Resources 5
       �� 
TargetType �� Property �� Value   InfoTextBlock  ScoreTextBlock �� Color 	 Brush��%R  '��       &	  �     &	 �    &	 �    'm� �    �� 5   
   " ��6   .�5      ��  �@��CornerRadius$ 10��6-   6:   �� 5       � ��
 ����6@   �� 5       � ��$ 5,5,5,0q�6'   69   5      �� 5   
   " ��6   .�5      ��  � ��$ 24(�6)   66   �� 5       � ��$ Arial)�6+   6;   �� 5       � ��$ 
ExtraBlack"�6+   6@   �� 5       � ��$ 5,5,5,0q�6'   69   5      �� 5   
   " ��6   .�5      ��  � ��$ 24(�6)   66   �� 5       � ��$ Arial)�6+   6;   �� 5       � ��$
 Bold"�6+   6:   �� 5       � ��$ Center=�64   6E   �� 5       � ��$ 0,5,5,5q�6'   69   5      �� 5   
   $ 	LightGray��6   6<   �� 5   
   " m�6   .�5      ��  � ��$ 15(�6)   66   �� 5        � ��
 �����6;   5!      5"      .��5%      �  � RowDefinitions 5&   
   �� 5'      $
��auto �6   �� 5(      $
��auto �6   �� 5)      $��* �6   .+�5,   
   o� $��0��6   .@�5-      m� $
��Menu��6   .@�5.      m� $��Restart��6   6/   m� 5/      $
��Exit��6   6+   50      51      � 53   
   $��1��6   $��
15,15,15,0q�6    � ColumnDefinitions 54      �� 55      $��* �6#   �� 56      $��* �6#   .+�59      �� $��0��6   ._�5:      �� .+�5;      �� $��Score��6    #��[  6-   �� 5<      $��0��6    #��[ 6)   5=      5>      �� 5@      $��1��6   ._�5A      �� .+�5B      �� $��	Max Score��6    #��[  61   �� 5C      $��0��6    #��[ 6)   5D      5E      5F      � 5H   
   $��2��6   $
��auto��6   $
��auto��6)   $��20q�67    5I      �� 5J      $��* �6    �� 5K      $��* �6    �� 5L      $��* �6    �� 5M      $��* �6     5O      �� 5P      $��* �6#   �� 5Q      $��* �6#   �� 5R      $��* �6#   �� 5S      $��* �6#   .+�5U      �� $��0��6   $��0��6#   �� 5V      $��0��6   $��1��6#   �� 5W      $��0��6   $��2��6#   �� 5X      $��0��6   $��3��6#   �� 5Y      $��1��6   $��0��6#   �� 5Z      $��1��6   $��1��6#   �� 5[      $��1��6   $��2��6#   �� 5\      $��1��6   $��3��6#   �� 5]      $��2��6   $��0��6#   �� 5^      $��2��6   $��1��6#   �� 5_      $��2��6   $��2��6#   �� 5`      $��2��6   $��3��6#   �� 5a      $��3��6   $��0��6#   �� 5b      $��3��6   $��1��6#   �� 5c      $��3��6   $��2��6#   �� 5d      $��3��6   $��3��6#   5e      5f      5g      