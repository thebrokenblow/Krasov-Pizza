   M S B A M L   `   `   `  ????O  KKrasovPizzaViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:KrasovPizzaViewModel;assembly=KrasovPizzaViewModelKrasovPizzaViewModel  5   	    KrasovPizzaView   KrasovPizzaView.MenuView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   [krasovpizzaviewmodel@clr-namespace:KrasovPizzaViewModel;assembly=KrasovPizzaViewModel  5   	     ? Title$  
MainWindow??5
   	   $	??650??6   $
??1200??6)   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??90 ?6   ?? 5      $??* ?6   .+?5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $??13q?5      $??0??5         Mode$ 
PrimaryMid=?5      .??5      ]? .+?5      ?? $??16,0,0,0q?5      $
??Left=?5      $??Center=?5      $??Krasov Pizza??5      $??25(?5      ?? 5       ?? Orientation$ 
Horizontal=?5      $??Right=?5      $??Center=?5      .+?5        $??40??5       $??Right=?5!      $??15 10q?5"      $??8 4 8 4q?5#       K? ZIndex$ 1??5$      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp6=?5%         CornerRadius$ 2??5&      $ Standard=?5'      .??5(      ?  ? ColumnDefinitions 5)      ?? 5*   "   $
??Auto ?5+   %   ?? 5,   "   $??* ?5-   %   ?? 5.   "   $
??Auto ?5/   %   .+?52      '  !MaterialDesignThemes.Wpf.PackIcon  $??Center=?53   !      Kind$ Search=?54   !   	 J? Opacity$		 .56Q?55   !   $??20??56   !   $??20??57   !   ?? 59      
 ?? 
IsEditable$

 True??5;   !   $??1??5<   !   $	??250??5=   !   $??8,0,0,0q?5>   !   $??Center=?5?   !   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск??5@   !   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=?5A   !   $??0q?5B   !   ??5:   !   ?? *NameProduct+5B   !   5C      5D      %  MaterialDesignThemes.Wpf.Badged  5F      $??12 10q?5G         Badge$ Кабинет??5H      .??5I      ?? $	 Dp4=?5J       *  &MaterialDesignFloatingActionMiniButton#??[  5K      .??5L        
???   ?$??30??5N   !   $??30??5O   !   $ Account=?5P   !   5Q      5R        5T      $??12 10q?5U       5V      ?? *CountOfCart+ ?? UpdateSourceTrigger$ PropertyChanged=?.??5W      ?? -   5        #??[  5Y      $	 Dp4=?5Z      .??5[        
???   ?$??30??5]   !   $??30??5^   !   $
 Cart=?5_   !   5`      5a      5b      5c      5d      ?? 5f   
   $??1??5g      $??False??5h        MenuProductItem#??[ 5j      ??5i      ?? *
Products+??5k      ?? 5l      .R?5m      ? 5n      5p      5r      5s      