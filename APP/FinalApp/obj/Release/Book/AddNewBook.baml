   M S B A M L   `   `   `  ���� C  ?FinalApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FinalApp.BookFinalApp.Book      FinalApp.Book.AddNewBook   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:FinalApp.Book     -     � 
ResizeMode$  NoResize=� � Title$$ افزودن کتاب جدید��$	��580��$	��600��$��20(�$��B Zar)�.��� ���#B3D9FF.+��� 
���   �$��1q�$��5,5,5,5q�._�� .+��� -    ��Name$
 lbl1��$��471,3,12,483q�$��نام کتاب�� �� TextAlignment$ Right=��� -    ��Name$ txtTitle��$��308,37,10,452q��� -   $
 lbl2��$��225,6,297,484q�$��
خلاصه��$ Right=��� -   $ 
txtSummary��$��10,36,294,452q��� -   $ 	lbl2_Copy��$��541,73,10,415q�$��ژانر��$ Right=��� -    ��Name$ txtGenre��$��308,107,7,383q����� .R��� ���� *	GenreName+�� -   $ 
lbl2_Copy2��$��239,73,295,418q�$��ناشر��$ Right=��� -	   $ txtPublisher��$��7,107,294,383q����� .R��� ���� *PublisherName+�� -
   $ 
lbl2_Copy3��$��514,147,10,346q�$��نویسنده��$ Right=��� -   $ 	txtAuthor��$��308,181,7,310q����� .R��� ���� *Name+�� -   $ 
lbl2_Copy7��$��182,147,294,344q�$��تاریخ تالیف��$ Right=�(  "System.Windows.Controls.DatePicker  -     Name$ dtpWriteDate��$��7,180,294,308q��� -   $ 
lbl2_Copy4��$��232,219,294,273q�$��
تعداد��$ Right=��� -   $ txtQuantity��$��7,252,294,240q��� -   $ 
lbl2_Copy1��$��519,217,10,275q�$��قیمت��$ Right=��� -   $ txtPrice��$��308,252,7,240q��� -   $ 
lbl2_Copy6��$��182,290,294,204q�$��مبلغ تخفیف��$ Right=��� -   $ txtDiscountAmount��{�.  $��7,323,294,171q��� -    ��Name$ chbHasDiscount�� d� 	IsChecked$ FalseY�$B��<آیا این محصول شامل تخفیف می باشد؟��$
��Left=�$��Center=�$��RightToLeft=�$��16(�$��353,316,8,169q��� -   	 ��Name$	 btnAddNewBook��$��افزودن��$��30��$	��160��$��39,382,39,10q��� -   $��10,494,534,10q�$"��/Images/icons8-return-48.png��$
��Fill=�