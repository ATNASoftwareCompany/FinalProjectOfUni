   M S B A M L   `   `   `  ����C  ?FinalApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FinalApp.UsersFinalApp.Users  5   	   #    FinalApp.Users.UsersManagment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FinalApp.Users     5   	   -   5          � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   
������  � AllowsTransparency .  � Title$ UsersManagment��5   	   $	��450��6    $	��800��6-   $��B Zar)�69   .��5      �� $��5q�6   ���#494947 �� CornerRadius$ 15��67   ._�5   
   � ���#494947.+�5      �� ���#F5F5DC$��5q�6+   $ 15��6?   $��15,10,404,20q�6Q   ._�5      � ���#F5F5DC.+�5      �� -   5         ��Name$ txbUserNODesc��5       $��مدیریت افراد��67   $��30(�6K   $��10,10,10,336q�6Y    �� TextAlignment$ Center=�6o   &   System.Windows.Controls.DataGrid  5      -   5          Name$ prsGrid��5      ���#44CCFF$��RightToLeft=�6E   	   
IsReadOnly	 . $��15,105,15,15q�6s   
   AutoGenerateColumns
 .     CanUserAddRows .  ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ردیف��61      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	RowNumber+6]     5      $
 auto 61   $ نام��6>    6K   �� *Name+  5      $
 auto 61   $ نام خانوادگی��6>    6T   �� *Family+  5      $
 auto 61   $ تاریخ تولد��6>    6R   �� *	BirthDate+  5      $
 auto 61   $ شماره تماس��6>    6R   �� *	PhoneNo+  5      $
 auto 61   $ 
ایمیل��6>    6M   �� *E_Mail+  5      $
 auto 61   $ 
وضعیت��6>    6M   �� *	StatusStr+  5      $
 auto 61   $ تاریخ ثبت نام��6>    6U   �� *
InsertDate+  5      $
 auto 61   $. (تاریخ آخرین بروزرسانی��6>    6]   �� *
UpdateDate+5      5       5!      �� 5"      ���#44CCFF$��5q�6+   $ 15��6?   $��404,10,15,20q�6Q   ._�5#      � ���#44CCFF.+�5$      �� -   5        $ txbUserNODescw��5$       $!��مدیریت کاربران��68   $��30(�6N   $��16,10,25,337q�6\   $ Center=�6r     5%      -   5        $ userGrid��5%      ���#F5F5DC$��RightToLeft=�6F   	 . $��15,105,15,15q�6t   
 .   .  ��6�   ��  5&        5'      $
 auto 61   $ ردیف��6>    6L   �� *	RowNumber+  5(      $
 auto 61   $ نام کاربری��6>    6R   �� *
UserName+  5)      $
 auto 61   $ 
وضعیت��6>    6M   �� *	StatusStr+  5*      $
 auto 61   $ تاریخ ثبت نام��6>    6U   �� *
InsertDate+  5+      $
 auto 61   $. (تاریخ آخرین بروزرسانی��6>    6]   �� *
UpdateDate+5-      5.      5/      �� 50      -   5        $��0,408,756,0q�50      $"��/Images/icons8-return-48.png��6)   $
��Fill=�6O   6^   51      53      54      