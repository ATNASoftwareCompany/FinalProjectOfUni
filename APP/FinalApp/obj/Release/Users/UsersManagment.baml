   M S B A M L   `   `   `  ���� C  ?FinalApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FinalApp.UsersFinalApp.Users  #    FinalApp.Users.UsersManagment   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:FinalApp.Users     -     � 
ResizeMode$  NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�
������  � AllowsTransparency .  � Title$ UsersManagment��$	��450��$	��800��$��B Zar)�.���� $��5q����#494947 �� CornerRadius$ 15��._�� ���#494947.+��� ���#F5F5DC$��5q�$ 15��$��15,10,404,20q�._�� ���#F5F5DC.+��� -    ��Name$ txbUserNODesc��$��مدیریت افراد��$��30(�$��10,10,10,336q� �� TextAlignment$ Center=�&   System.Windows.Controls.DataGrid  -     Name$ prsGrid�����#44CCFF$��RightToLeft=�	   
IsReadOnly	 . $��15,105,15,15q�
   AutoGenerateColumns
 .     CanUserAddRows .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ردیف��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	RowNumber+  $
 auto $ نام�� �� *Name+  $
 auto $ نام خانوادگی�� �� *Family+  $
 auto $ تاریخ تولد�� �� *	BirthDate+  $
 auto $ شماره تماس�� �� *	PhoneNo+  $
 auto $ 
ایمیل�� �� *E_Mail+  $
 auto $ 
وضعیت�� �� *	StatusStr+  $
 auto $ تاریخ ثبت نام�� �� *
InsertDate+  $
 auto $. (تاریخ آخرین بروزرسانی�� �� *
UpdateDate+�� ���#44CCFF$��5q�$ 15��$��404,10,15,20q�._�� ���#44CCFF.+��� -   $ txbUserNODescw��$!��مدیریت کاربران��$��30(�$��16,10,25,337q�$ Center=�  -   $ userGrid�����#F5F5DC$��RightToLeft=�	 . $��15,105,15,15q�
 .   .  ����    $
 auto $ ردیف�� �� *	RowNumber+  $
 auto $ نام کاربری�� �� *
UserName+  $
 auto $ 
وضعیت�� �� *	StatusStr+  $
 auto $ تاریخ ثبت نام�� �� *
InsertDate+  $
 auto $. (تاریخ آخرین بروزرسانی�� �� *
UpdateDate+�� -   $��0,408,756,0q�$"��/Images/icons8-return-48.png��$
��Fill=�