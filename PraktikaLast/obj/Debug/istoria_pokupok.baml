   M S B A M L   `   `   `  ����G  CPraktikaLast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PraktikaLastPraktikaLast  5   	   "    PraktikaLast.istoria_pokupok   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PraktikaLast     5   	     � Title$  istoria_pokupok��5   	   $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � .+�5
   
   o� $��121,10,120,334q�6   .@�5      �� -   5         ��Name$ button_roli��5      $	��145��6*   $��Покупатель��66   6K   �� 5      -   5        $ Button_sotrudniki��5      $	��145��60   $��Тип оплаты��6<    � Cursor$
 Hand��6Q   6_   �� 5      -   5        $ Button_sotrudniki_Copy1��5      $	��145��66   $#��История покупок��6B   $
 Hand��6\   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ RoliGrid��5      $��10,95,264,10q�6P   6f   �� 5   
   -   5        $ Button_udalenie��5       "  MaterialDesignRaisedDarkButton#��[  5      $��Удалить��5      $��541,163,10,-204q�5      $
 Hand��6D   �� 5   
   -   5        $ button_izmena��5      #��[  5      $��Изменить��5      $��541,195,10,-76q�5      6%   �� 5   
   -   5        $ Button_dobavit��5      #��[  5      $��Добавить��5      $��541,132,10,-44q�5      6%   �� 5   
   -   5         ��Name$ RolBox��5        MaterialDesignFilledTextBox#��[ 5      $	��Top=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Количество��5      $��541,69,10,0q�69   .��6N   ��5       �� 5!       �� Path$ Text1�5"       �� UpdateSourceTrigger$ PropertyChanged=�5#      5$      .��5%      5&      �� 5'   
   -	   5        	 ��Name$	 combo_pokupatel��5'      $% Номер покупателя��6,   $
��Left=�6^   $��594,224,0,0q�6y   $	��Top=�6�   $	��144��6�   �� 5(   
   -
   5        $	 combo_tovar��5(      $ Номер товара��6(   $
��Left=�6V   $��594,194,0,0q�6q   $	��Top=�6�   $	��144��6�   �� 5)   
   -   5        $	 combo_sotdudnik��5)      $% Номер сотрудника��6,   $
��Left=�6^   $��594,164,0,0q�6y   $	��Top=�6�   $	��144��6�   �� 5*   
   -   5        $	 	combo_tip��5*      $&  Номер типа оплаты��6&   $
��Left=�6Y   $��594,134,0,0q�6t   $	��Top=�6�   $	��144��6�   5+      5,      