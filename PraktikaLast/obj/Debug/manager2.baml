   M S B A M L   `   `   `  ����G  CPraktikaLast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PraktikaLastPraktikaLast  5   	       PraktikaLast.manager2   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PraktikaLast     5   	     � Title$  manager2��5   	   $	��450��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�63   .��5	      � .+�5
   
   o� $��158,10,157,338q�6   .@�5      �� -   5         ��Name$ button_roli��5      $	��200��6*   $��Категории��66   6J   �� 5      -   5        $ Button_sotrudniki��5      $	��200��60   $��
Товар��6<    � Cursor$
 Hand��6L   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ RoliGrid��5      $��10,95,264,81q�6P   6f   �� 5   
   -   5        $ Button_udalenie��5       "  MaterialDesignRaisedDarkButton#��[  5      $��Удалить��5      $��541,163,10,-204q�5      6&   �� 5   
   -   5        $ button_izmena��5      #��[  5      $��Изменить��5      $��541,195,10,-76q�5      6%   �� 5   
   -   5        $ Button_dobavit��5      #��[  5      $��Добавить��5      $��541,132,10,-44q�5      $
 Hand��6%   63   �� 5   
   -   5         ��Name$ nazvaniebox��5        MaterialDesignFilledTextBox#��[ 5      $	��Top=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Название��5      $��541,101,10,0q�67   ��6M   �� *Text1+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   -   5        $ stoimostbox��5      #��[ 5       $	��Top=�5!      $ Стоимость��5"      $��541,151,10,0q�68   ��6N   �� *Text1+$ PropertyChanged=��� 5#   
   -	   5        $ kolichestvobox��5#      #��[ 5$      $	��Top=�5%      $, &Количество на складе��5&      $��541,201,10,0q�6C   ��6Y   �� *Text1+$ PropertyChanged=��� 5'   
   -
   5         ��Name$ combo��5'      $# Номер категории��6"   $
��Left=�6S   $��400,358,0,0q�6n   $	��Top=�6�   $	��120��6�   5(      5)      