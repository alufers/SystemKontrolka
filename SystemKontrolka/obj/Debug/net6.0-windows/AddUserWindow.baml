   M S B A M L   `   `   `  ����J  FSystemKontrolka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SystemKontrolkaSystemKontrolka  5   	   #    SystemKontrolka.AddUserWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SystemKontrolka     5   	   -   5          � Title$(  "Kontrolka - dodawanie użytkownika��5   	   $	��450��63   $	��800��6@   .��5	      �� -   5        $��MainStackPanel��5	   (    �� Orientation$ Vertical=�6   .+�5
   
   � $��30��6   ���	#FFADADAD � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��300 �6#   .+�5      �� $��Dodawanie użytkownika��6   $��0��66   $��Center=�6F   $
��Bold"�6a   $��16(�6s   6�   �� 5      $��login_bg.jpg��6   $��1��6*   $��UniformToFill=�6:    J� RenderTransformOrigin$ 0.5,0.5&�6R   z�5      V� 5      .~�5      �� �� 5       �� AngleX$	 -30Q�6(   �� 5      T� 5       T� X$
 -100Q�6-   5      5      5      �� 5   
   $��Nazwa użytkownika��6   $��10,5,5,5q�6,   6@   �� 5   
   -   5        $��UserNameTextBox��5   #   $��5,5,5,5q�6   $��30��6:   6H   �� 5   
   $��Hasło��6   $��10,5,5,5q�6    64   �� 5   
   -   5        $��PasswordTextBox��5   #   $��5,5,5,5q�6   $��30��6:   6H   �� 5    
   $��Powtórz hasło��6   $��10,5,5,5q�6(   6<   �� 5!   
   -   5        $��PasswordRepeatTextBox��5!   #   $��5,5,5,5q�6   $��30��6@   6N   �� 5"   
   $��1��6   �� 5#   
   -   5        $��CanEditUsersCheckBox��5#   O   $'��!Uprawnienie edycji użytkowników��6   $��10,5,5,5q�6=   6m   �� 5$   
   -   5        $��CanEditReportsCheckBox��5$   K   $"��Uprawnienie edycji raportów��6   $��10,5,5,5q�69   6k   �� 5%   
   -   5        $��CanEditPartsCheckBox��5%   X   $0��*Uprawnienie edycji kontrolowanych części��6   $��10,5,5,5q�6F   6v   �� 5&   
   -	   5        $ ��CanEditDefectTypesCheckBox��5&   Q   $)��#Uprawnienie edycji typów defektów��6   $��10,5,5,5q�6?   6u   �� 5(   
   -
   5        $��SaveUserButton��5(   #   $��10,5,5,5q�6   $��Zapisz��69   $��30��6J   $	��200��6V   $��Center=�6b   $��Center=�6   6�   5*      5+      