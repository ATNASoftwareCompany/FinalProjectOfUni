   M S B A M L   `   `   `  ���� C  ?FinalApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FinalApp.BookFinalApp.Book  !    FinalApp.Book.BookManagment   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:FinalApp.Book     -     � 
ResizeMode$  NoResize=� � Title$  مدیریت کتاب ها��$	��700��$
��1000��$��B Zar)�$��16(�.��� ���#B3D9FF.+��� $	��215��$	��600��$��370,-5,10,400q�$��1q�
���   �._�� .+��� $ ��مدیریت کتاب ها��$��Right=�$	��Top=�$��22��$��15(�$��	0,-20,0,0q�$	��100���� -    ��Name$ btnAddNewBook��$$��افزودن کتاب جدید��$��25��$	��Top=�$��10,12,480,0q�&   System.Windows.Controls.DataGrid  -     Name$ BooksDataGrid��   
IsReadOnly . ���#F5F5DC   AutoGenerateColumns .  $��10,40,10,10q�$��Center=�$��RightToLeft=�$��Center=�   CanUserAddRows .  $��1q�
���   �$��2������  � ContextMenu �� .@�m� -    m�Name$ BookData��$��حذف��	 m� Command	 �� *DeleteCommand+
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ردیف��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	RowNumber+  $ نام کتاب��$ *  �� *	BookTitle+  $ * $ تعداد(جلد)�� �� *
Quantity+  $ * $ ژانر�� �� *	BookGenre+  $ * $ نویسنده�� �� *Author+  $ * $ ناشر�� �� *	Publisher+  $ * $ قیمت(تومان)�� �� *Price+  $ * $ تاریخ تالیف�� �� *	WriteDate+�� $��10,20,628,424q�$��1q�
���   �._�� .+��� $��
جستجو��$��Right=�$	��Top=�$��22��$��15(�$��	0,-20,4,0q�$��51���� $��
جستجو��$��	130,5,0,0q��� -    ��Name$ 	txtSearch��$��RightToLeft=�$��10,30,170,155q��� $��نوع جستجو��$��	275,5,0,0q��� -    ��Name$ cobSearchType��$��180,30,10,155q�.@��� $��کتاب���� $��ژانر���� $��نویسنده���� $��ناشر��  -   $ grdBookNameSearch�� .  ���#F5F5DC .  .  $��RightToLeft=�$��10,70,10,10q�
   $ ردیف��$
 Auto  �� *	RowNumber+  $ نام کتاب��$
 Auto  �� *	BookTitle+  $
 Auto $ تعداد(جلد)�� �� *
Quantity+  $
 Auto $ ژانر�� �� *	BookGenre+  $
 Auto $ نویسنده�� �� *Author+  $
 Auto $ ناشر�� �� *	Publisher+  $
 Auto $ قیمت(تومان)�� �� *Price+  $
 Auto $ تاریخ تالیف�� �� *	WriteDate+  -   $ grdPublisherNameSearch�� .  ���#F5F5DC .  .  $��RightToLeft=�$y�Hidden=�$��10,70,10,10q�
   $ ردیف��$
 Auto  �� *	RowNumber+  $ نام ناشر��$ *  �� *	Publisher+  -	   $ grdAuthorNameSearch�� .  ���#F5F5DC .  .  $��RightToLeft=�$��10,70,10,10q�$y�Hidden=�
   $ ردیف��$
 Auto  �� *	RowNumber+  $ نام نویسنده��$ *  �� *Author+  -
   $ grdGenreNameSearch�� .  ���#F5F5DC .  .  $��RightToLeft=�$��10,70,10,10q�$y�Hidden=�
   $ ردیف��$
 Auto  �� *	RowNumber+  $ ژانر��$ *  �� *Genre+�� $��10,279,670,57q�$��1q�
���   �._�� .+��� $ ��مدیریت ژانر ها��$��Right=�$	��Top=�$��22��$��15(�$��0,-20,-20,0q�$	��100��  -   $ GenresDataGrid�����#F5F5DC .  $��9,35,9,9q�$��Center=�$��RightToLeft=� . $��Center=� .  $��1q�
���   �����  �� .@�m� -   $ 	GenreData��$��حذف��	 �� *DeleteCommand+
   $ ردیف��$
 Auto  �� *	RowNumber+  $ ژانر��$ *  �� *Genre+�� -   $ btnAddNewGenre��$$��افزودن ژانر جدید��$��25��$	��Top=�$��	9,9,200,0q��� $��344,279,344,57q�$��1q�
���   �._�� .+��� $%��مدیریت نویسندگان��$��Right=�$	��Top=�$��22��$��15(�$��
0,-20,-1,0q�$	��100��  -   $ AuthorsDataGrid�����#F5F5DC .  $��9,35,9,9q�$��Center=�$��RightToLeft=�$��Center=� .  $��1q�
���   �����  �� .@�m� -   $ 
AuthorData��$��حذف��	 �� *DeleteCommand+
   $ ردیف��$
 Auto  �� *	RowNumber+  $ نام نویسنده��$ *  �� *Author+�� -   $ btnAddNewAuthor��$*��$افزودن نویسنده جدید��$��25��$	��Top=�$��	9,9,170,0q��� $��678,279,10,57q�$��1q�
���   �._�� .+��� $��مدیریت ناشران��$��Right=�$	��Top=�$��22��$��15(�$��0,-20,-20,0q�$	��100��  -   $ PublishersDataGrid�����#F5F5DC .  $��9,35,9,9q�$��Center=�$��RightToLeft=�$��Center=� .  $��1q�
���   �����  �� .@�m� -   $ PublisherData��$��حذف��	 �� *DeleteCommand+
   $ ردیف��$
 Auto  �� *	RowNumber+  $ نام ناشر��$ *  �� *	Publisher+�� -   $ btnAddNewPublisher��$$��افزودن ناشر جدید��$��25��$	��Top=�$��	9,9,180,0q��� -   $��10,610,935,10q�$"��/Images/icons8-return-48.png�� � ToolTip$ خروج��$
��Fill=�$��40��