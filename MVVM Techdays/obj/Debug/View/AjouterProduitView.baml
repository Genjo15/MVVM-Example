   M S B A M L   `   `   `  ����H  DMVVM Techdays, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MVVM_Techdays.ViewModelMVVM_Techdays.ViewModel  5      +    %MVVM_Techdays.View.AjouterProduitView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8models%clr-namespace:MVVM_Techdays.ViewModel     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Nom : ��6   �� 5   
   $��Categorie : ��6   $��1��6(   �� 5   
   $��Quantite disponible : ��6   $��2��62   �� 5   
   $��Quantite commandee : ��6   $��3��61   �� 5   
   $��1��6   $��0��6"   ��6/   �� *Produit.Nom+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5   
   $��1��6   $��1��6"   ��6/   �� *Produit.Categorie+$ PropertyChanged=�$ TwoWay=��� 5   
   $��1��6   $��2��6"   ��6/   �� *Produit.QuantiteDispo+$ TwoWay=��� 5   
   $��1��6   $��3��6"   ��6/   �� *Produit.QuantiteCommande+$ TwoWay=�5      5      