   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2      WpfApp2.TransactionWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     M IFluent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546fFluenturn:fluent-ribbon  !localclr-namespace:WpfApp2    � Title$  New Transaction��$	��591��$	��566��  Fluent.RibbonWindow   TitleBackground �	#FF0078D7   TitleBarHeight$ 30Q�   IsIconVisible .   � 
ResizeMode$ NoResize=�
������� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $
��386* ��� $	��61* ��� $
��113* �.+��� $
��Type��$
��Left=�$��
305,34,0,0q�$	��Top=� J� RenderTransformOrigin$ -0.111,0.208&�$��14(��� $
��Left=�$��	18,36,0,0q�$	��Top=�$	��120�� �� SelectedIndex$ 0��$��14(�$��2�����	#EE000000$��1��.@��� $��Income��$
��Left=�$	��118���� $��Expense��$
��Left=�$	��118���� $��Transfer��$
��Left=�$	��118��&   System.Windows.Controls.Calendar  $
��Left=�$��	32,56,0,0q�$	��Top=����	#FFD1D1D1�� $��Category��$
��Left=�$��
305,81,0,0q�$	��Top=�$ -0.111,0.208&�$��14(��� $
��Left=�$��	18,81,0,0q�$	��Top=�$	��120��$ 0��$��14(�$��2�����	#EE000000$��1��.@��� $
��Food��$
��Left=�$	��118���� $	��Bag��$
��Left=�$	��118���� $��Shoes��$
��Left=�$	��118���� $��Group��$
��Left=�$��305,130,0,0q�$	��Top=�$ -0.111,0.208&�$��14(��� $
��Left=�$��
18,128,0,0q�$	��Top=�$	��120��$ 0��$��14(�$��2�����	#EE000000$��1��.@��� $��My Home Business��$
��Left=�$	��118���� $��Job Business��$
��Left=�$	��118���� $��ComboBoxItem��$
��Left=�$	��118���� $��Payer/Payee��$
��Left=�$��305,177,0,0q�$	��Top=�$ -0.111,0.208&�$��14(�$��2���� $
��Left=�$��
19,175,0,0q�$	��Top=�$	��120��$ 0��$��14(�$��2�����	#EE000000$��1��.@��� $��Walmort��$
��Left=�$	��118���� $	��Bag��$
��Left=�$	��118���� $��Shoes��$
��Left=�$	��118���� $��From Account��$
��Left=�$��306,221,0,0q�$	��Top=�$ -0.111,0.208&�$��14(�$��2���� $
��Left=�$��
19,223,0,0q�$	��Top=�$	��120��$ 0��$��14(�$��2�����	#EE000000$��1��.@��� $��Chase��$
��Left=�$	��118���� $��Expense��$
��Left=�$	��118���� $��Transfer��$
��Left=�$	��118���� $��
To Account��$
��Left=�$��306,270,0,0q�$	��Top=�$ -0.111,0.208&�$��14(��� $
��Left=�$��
19,270,0,0q�$	��Top=�$	��120��$ 0��$��14(�$��2�����	#EE000000$��1��.@��� $��Not Applicable��$
��Left=�$	��118���� $	��Bag��$
��Left=�$	��118���� $��Shoes��$
��Left=�$	��118���� $��Amount��$
��Left=�$��306,317,0,0q�$	��Top=�$ -0.111,0.208&�$��14(��� $��Comment��$
��Left=�$��306,365,0,0q�$	��Top=�$ -0.111,0.208&�$��14(��� $��Receipt��$
��Left=�$��306,409,0,0q�$	��Top=�$ -0.111,0.208&�$��14(��� $
��Left=�$��23��$��
19,321,0,0q�	 �� TextWrapping$
	 Wrap=�$	��$50��$	��Top=�$	��120��$��0q�$��2�����	#EE000000$��1���� $
��Left=�$��23��$��
19,366,0,0q�$
	 Wrap=�$	��Top=�$	��120��$��0q�$��2�����	#EE000000$��1���� $
��Left=�$��23��$��
19,411,0,0q�$
	 Wrap=�$	��Top=�$	��120��$��0q�$��2�����	#EE000000$��1���� -   $
��Save��$
��Left=�$��168,486,0,0q�$	��Top=�$��75��4  .System.Windows.Automation.AutomationProperties
   Name$
 SaveTransactionBtn���� -   $��Close��$
��Left=�$��326,486,0,0q�$	��Top=�$��75�����	#FFBDC9CF
������ $��2��$
 CloseTransactionBtn��