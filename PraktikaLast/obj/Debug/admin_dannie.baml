   M S B A M L   `   `   `  ����G  CPraktikaLast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PraktikaLastPraktikaLast  5   	       PraktikaLast.admin_dannie   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PraktikaLast     5   	     � Title$  admin_dannie��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67   .��5	      � .+�5
   
   o� $��40,10,40,336q�6   .@�5      �� -   5         ��Name$ button_roli��5      $	��200��6*   $��Роли��66   6E   �� 5      -   5        $ Button_sotrudniki��5      $	��200��60   $)��#Данные сотрудников��6<    � Cursor$
 Hand��6Y   6g   �� 5      -   5        $ Button_sotrudniki_Copy��5      $	��200��65   $$��Данные для входа��6A   $
 Hand��6\   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ RoliGrid��5      $��10,95,264,113q�6P   6g   �� 5   
   -   5         ��Name$ combo��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Номер должности��6"   $
��Left=�6S   $��400,358,0,0q�6n   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ Button_udalenie��5       "  MaterialDesignRaisedDarkButton#��[  5      $��Удалить��5      $��541,163,10,-204q�5      6&   �� 5   
   -   5        $ button_izmena��5      #��[  5      $��Изменить��5      $��541,195,10,-76q�5      6%   �� 5   
   -   5        $ Button_dobavit��5      #��[  5      $��Добавить��5      $��541,132,10,-44q�5      $
 Hand��6%   63   �� 5   
   -	   5         ��Name$ RolBox��5        MaterialDesignFilledTextBox#��[ 5      $	��Top=�5      $ 
Логин��5       $��541,103,10,0q�64   .��6J   ��5!      �� 5"       �� Path$ Text1�5#      	 �� UpdateSourceTrigger$	 PropertyChanged=�5$      5%      .��5&      5'      G� 5(   
   -
   5        
 G�Name$
 password��5(       # MaterialDesignFilledPasswordBox#��[ 5)      $ Password��5+      $��541,173,10,200q�67   {�5*      �� *	IsChecked+ �� ElementName$4 .MaterialDesignFilledPasswordBoxEnabledComboBox��5+   7   5,      5-      