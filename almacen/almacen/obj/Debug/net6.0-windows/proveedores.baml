   M S B A M L   `   `   `  ����B  >almacen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:almacenalmacen  5   	       almacen.proveedores   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:almacen     5   	     � Title$  proveedores��5   	   $	��450��6   $	��800��6*   .��5	      � $��0,0,2,0q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF62ED0F��6    � Offset$ 1Q�61   5      .+�5   
   �� $��PROVEEDORES��6   $
��Left=�6&   $��39��6A   $��
242,10,0,0q�6M   $	��Top=�6a   $	��259��6y   �� 5   
   $��PROVEEDORES��6   $
��Left=�6&   $��39��6A   $��
242,10,0,0q�6M   $	��Top=�6a   $	��259��6y    J� RenderTransformOrigin$ 0.538,0.942&�6�   ���	#FF8BE50A6�   �� 5   
   $��ID DE PROVEEDOR��6   $
��Left=�6*   $��36��6E   $��	21,58,0,0q�6Q   $	��Top=�6d   $	��156��6|   $ 0.538,0.942&�6�   ���	#FF7AFD2B6�   �� 5   
   $��NOMBRE DE EMPRESA��6   $
��Left=�6,   $��39��6G   $��
21,115,0,0q�6S   $	��Top=�6g   $	��156��6   $ 0.538,0.942&�6�   ���	#FF61DA196�   �� 5   
   $��NOMBRE DE CONTACTO��6   $
��Left=�6-   $��38��6H   $��
21,172,0,0q�6T   $	��Top=�6h   $	��156��6�   $ 0.538,0.942&�6�   ���	#FF74FF226�   �� 5   
   $��	DIRECCION��6   $
��Left=�6$   $��39��6?   $��
21,218,0,0q�6K   $	��Top=�6_   $	��156��6w   $ 0.538,0.942&�6�   ���	#FF74EB2D6�   �� 5   
   $��TELEFONO��6   $
��Left=�6#   $��39��6>   $��
21,271,0,0q�6J   $	��Top=�6^   $	��156��6v   $ 0.538,0.942&�6�   ���	#FF61E0156�   �� 5   
   $��CORREO ELECTRONICO��6   $
��Left=�6-   $��35��6H   $��
21,315,0,0q�6T   $	��Top=�6h   $	��156��6�   $ 0.538,0.942&�6�   ���	#FF64C52B6�   �� 5   
   $��TERMINOS DE PAGO��6   $
��Left=�6+   $��34��6F   $��
21,372,0,0q�6R   $	��Top=�6f   $	��156��6~   $ 0.538,0.942&�6�   ���	#FF66CC2A6�   �� 5   
   -   5         ��Name$ ID��5      $
��Left=�6   $��34��69   $��
242,60,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��208��6�   �� 5   
   -   5        $ NOMBRE_EMPRESA��5      $
��Left=�6*   $��34��6E   $��242,120,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��208��6�   �� 5   
   -   5        $ NOMBRE_CONTACTO��5      $
��Left=�6+   $��34��6F   $��242,174,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��208��6�   �� 5   
   -   5        $ 	DIRECCION��5      $
��Left=�6%   $��34��6@   $��242,223,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��208��6�   �� 5   
   -   5        $ TELEFONO��5      $
��Left=�6$   $��34��6?   $��242,276,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��208��6�   �� 5   
   -   5        $ CORREO_ELECTRONICO��5      $
��Left=�6.   $��34��6I   $��242,316,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��208��6�   �� 5   
   -   5        $ TERMINO_PAGO��5      $
��Left=�6(   $��34��6C   $��242,372,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��208��6�   �� 5    
   -   5         ��Name$ OBTENER_PROVEEDOR��5       $��OBTENER PROVEEDOR��6,   $
��Left=�6H   $��52��6c   $��570,100,0,0q�6o   $	��Top=�6�   $	��194��6�   $��16(�6�   ��5!      �� 5"      $ 0.5,1&�6&   $ 0.5,0&�67   .��5#      � $ Black��6#   � 5$      $ 	#FF44ED1B��6#   $ 1Q�65   5%      5'      �� 5(   
   -	   5        $ AGREGAR_PROVEEDOR��5(      $��AGREGAR PROVEEDOR��6,   $
��Left=�6H   $��45��6c   $��570,172,0,0q�6o   $	��Top=�6�   $	��194��6�   $��14(�6�   ��5)      �� 5*      $ 0.5,1&�6&   $ 0.5,0&�67   .��5+      � $ Black��6#   � 5,      $ 	#FF3EED2D��6#   $ 1Q�65   5-      5/      �� 50   
   -
   5        $ ACTUALIZAR_PROVEEDOR��50      $��ACTUALIZAR PROVEEDOR��6/   $
��Left=�6N   $��52��6i   $��570,238,0,0q�6u   $	��Top=�6�   $	��194��6�   $��14(�6�   ��51      �� 52      $ 0.5,1&�6&   $ 0.5,0&�67   .��53      � $ Black��6#   � 54      $ 	#FF21E51E��6#   $ 1Q�65   55      57      �� 58   
   -   5        $ ELIMINAR_PROVEEDOR��58      $��ELIMINAR PROVEEDOR��6-   $
��Left=�6J   $��49��6e   $��570,315,0,0q�6q   $	��Top=�6�   $	��194��6�   $��14(�6�   ��59      �� 5:      $ 0.5,1&�6&   $ 0.5,0&�67   .��5;      � $ Black��6#   � 5<      $ 	#FF4CE814��6#   $ 1Q�65   5=      5?      �� 5@   
   -   5        $ ABRIR_INVENTARIO��5@      $��ABRIR INVENTARIO��6+   $
��Left=�6F   $��52��6a   $��470,372,0,0q�6m   $	��Top=�6�   $	��182��6�   $��16(�6�   ��5A      �� 5B      $ 0.5,1&�6&   $ 0.5,0&�67   .��5C      � $ Black��6#   � 5D      $ 	#FF3DDD27��6#   $ 1Q�65   5E      5G      5I      5J      