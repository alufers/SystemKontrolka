   M S B A M L   `   `   `  ����J  FSystemKontrolka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SystemKontrolkaSystemKontrolka  5   	   %    SystemKontrolka.AddReportWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SystemKontrolka     5   	   -   5          � Title$#  Kontrolka - Dodawanie Raportu��5   	   $	��450��6/   $	��800��6<   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $��10,10,10,10q�6,   .+�5      �� $��Dodawanie raportu��6   $��
0,10, 0, 0q�60   $��24(�6D   $
��Bold"�6R   6f   �� 5      $��Opis usterki��6   �� 5      -   5        $��Description��5       �� TextWrapping$
 Wrap=�6*    �� AcceptsReturn$
 True��5      " �� VerticalScrollBarVisibility$ Visible=�5      $	��100��6)   �� 5      $��Część��6   �� 5      -   5        $��PartSelectionComboBox��5      $��0,0,0,10q�64    �� DisplayMemberPath$
 Name��6F    �� SelectedValuePath$
 Name��5      6,   �� 5      -   5        $��
WeightHint��5      6(   �� 5      -   5        $��
SaveButton��5      $��0, 20, 0, 0q�6'   $��40��6<   .��6a   Zapisz6i   5      5      5      